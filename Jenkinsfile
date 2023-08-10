pipeline {
    agent any

    stages {
        // Stage 1: Checkout the Source Code
        stage('Checkout') {
            steps {
                checkout scm
            }
        }
        
        // Stage 2: Build the Project
        stage('Build') {
            steps {
                script {
                    // Get some code from a GitHub repository
                    git 'https://github.com/genbertdacudao/PlusCalcConsole.git'
                    
                    def buildStatus = sh(returnStatus: true, script: 'dotnet build')
                    if (buildStatus == 0) {
                        echo "Build successful."
                    } else {
                        error "Build failed."
                    }
                }
            }
        }
    }
}
