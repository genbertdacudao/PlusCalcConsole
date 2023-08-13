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
            bat 'dotnet clean'
        }
    }

       stage('Restore') {
        steps {
            // Restore .NET dependencies
            bat 'dotnet restore'
            bat 'nuget restore'
        }
    }

        stage('Build') {
            steps {                
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
                bat 'mkdir -p C:/Users/Milbert/Desktop/PlusCalcProject'
                bat 'cp -r . C:/Users/Milbert/Desktop/PlusCalcProject'
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
