pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // Checkout your source code from Git
                checkout scm
            }
        }

        stage('Build') {
            steps {
                // Restore .NET dependencies
                sh 'dotnet restore'
                
                // Build the .NET project
                sh 'dotnet build --configuration Release'
            }
        }

        stage('Run Unit Tests') {
            steps {
                // Run unit tests
                sh 'dotnet test --configuration Release'
            }
        }

        stage('Deploy') {
            when {
                expression { currentBuild.resultIsBetterOrEqualTo('SUCCESS') }
            }
            steps {
                sh 'echo "Deploying artifacts..."'
                sh 'mkdir -p ~/Desktop/PlusCalcProject'
                sh 'cp -r . ~/Desktop/PlusCalcProject'
            }
        }
    }

    post {
        always {
            // Archive build artifacts or perform other post-build actions
            archiveArtifacts artifacts: '**/bin/Release/**', allowEmptyArchive: true
        }
    }
}
