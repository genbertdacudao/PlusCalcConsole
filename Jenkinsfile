pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // Checkout your source code from Git
                checkout scm
            }
        }

        stage('Clean') {
            steps {
                bat 'dotnet clean --configuration Release'
            }
        }

        stage('Restore') {
            steps {
                bat 'dotnet restore'
                bat 'nuget'
            }
        }
   
        stage('Build') {
            steps {
                dir('PlusCalcUnitTests/') {
                    bat 'dotnet build --configuration Release PlusCalcUnitTests.csproj'
                }
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
