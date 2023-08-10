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
                bat 'dotnet restore'
                
                // Build the .NET project
                bat 'dotnet build --configuration Release'
            }
        }

        stage('Run Unit Tests') {
            steps {
                // Run unit tests
                bat 'dotnet test --configuration Release'
            }
        }

        stage('Deploy') {
            when {
                expression { currentBuild.resultIsBetterOrEqualTo('SUCCESS') }
            }
            steps {
                bat 'echo "Deploying artifacts..."'
                bat 'mkdir -p ~/Desktop/PlusCalcProject'
                bat 'cp -r . ~/Desktop/PlusCalcProject'
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
