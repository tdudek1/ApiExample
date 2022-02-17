
pipeline { 
        agent {label 'linux'}  

    environment {
        DOTNET_CLI_HOME = "/tmp/DOTNET_CLI_HOME"
    }

    options {
        skipStagesAfterUnstable()
    }
    stages {
            
        stage('Build & Test') { 
            agent {
                label 'linux'
                docker { image 'mcr.microsoft.com/dotnet/sdk:6.0' }
            }
            stages {
                stage('Build') {
                    steps{
                        sh 'dotnet build .' 
                    }
                }
                stage('Test') {
                    steps{
                        sh 'dotnet test .' 
                    }
                }
                stage('Publish') {
                    steps{
                        sh 'dotnet publish ApiExample/ApiExample.csproj -c Release -r linux-x64 --self-contained true --output out -p:PublishSingleFile=true -p:IncludeAllContentForSelfExtract=true -p:UseAppHost=true' 
                    }
                }
            }
        }
    }
}