# Get all .csproj files recursively
rm -rf all.sln
projectFiles=$(find . -type f -name "*.csproj")

# Create an empty solution
dotnet new sln -n all

# Add each project to the solution
for project in $projectFiles; do
    echo $project
    dotnet sln all.sln add "$project"
done
