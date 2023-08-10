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

        // Stage 3: Run Unit Tests
        stage('Unit Tests') {
            steps {
                script {
                    def testStatus = sh(returnStatus: true, script: 'dotnet test')
                    if (testStatus == 0) {
                        echo "Tests passed."
                    } else {
                        error "Tests failed."
                    }
                }
            }
        }

        // Stage 4: Deploy Artifacts
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
    }
}
