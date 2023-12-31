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
                bat 'dotnet build --configuration Debug'
            }
        }

        stage('Run Unit Tests') {
            steps {
                // Run unit tests
                bat 'dotnet test --configuration Debug'
            }
        }

        stage('Deploy Project Artifacts') {
            when {
                expression { currentBuild.resultIsBetterOrEqualTo('SUCCESS') }
            }
            steps {
                bat 'echo "Deploying artifacts..."'
                // Deploy Project Artifacts to local machine
                bat "if not exist \"C:\\Users\\Milbert\\Desktop\\PlusCalcProject\" mkdir \"C:\\Users\\Milbert\\Desktop\\PlusCalcProject\""
                bat 'xcopy /E /Y . C:\\Users\\Milbert\\Desktop\\PlusCalcProject\\'
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
