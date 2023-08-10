pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // Checkout your source code from Git
                checkout scm
            }
        }

        stage('Git Clone') {
            steps {
                // Clone the repository using the git step
                script {
                    git branch: 'main', url: 'https://github.com/genbertdacudao/PlusCalcConsole.git'
                }
            }
        }


        stage('Restore') {
            steps {
                // Restore .NET dependencies
                sh 'dotnet restore'
            }
        }

        stage('Deploy') {
            steps {
                sh 'echo "Deploying artifacts..."'
                sh 'mkdir -p ~/Desktop/ConsoleProject'
                sh 'cp -r . ~/Desktop/ConsoleProject'
            }
            
            // Check Deployment Status
            post {
                success {
                    echo "Deployment successful."
                }
                failure {
                    error "Deployment failed."
                }
            }
        }

        stage('Build') {
            steps {
                // Build the .NET project
                sh 'dotnet build --configuration Release'
            }
        }

        // Add more stages as needed
    }

    post {
        always {
            // Archive build artifacts or perform other post-build actions
            archiveArtifacts artifacts: '**/bin/Release/**', allowEmptyArchive: true
        }
    }
}
