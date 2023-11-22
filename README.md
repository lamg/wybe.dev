# Wybe.dev

_wybe.dev_ is community for learning and training programming skills. It relies on GitHub,
and custom tools for creating problems, running solutions and connecting people.

## Usage

### Initialization

First install the `wybe` tool with the following command:

```sh
dotnet tool install -g wybetool
```

then we need to create our `wybe.dev` repository with:

```sh
wybe new
```

The newly created directory has the following structure:

- `.github/workflows/test-solution.yml`: GitHub action definition
- `solutions`: contains your solutions to problems
- `problems`: contains problems other users or you can solve
- `solutions/project.toml`: specifies which solutions should be tested
the next time you push to your wybe.dev repository in GitHub.

Create a GitHub repository with the name `wybe.dev` for storing 
and sharing its contents.

### Our first solution

Now we can start the solution to our first problem with

```
cd wybe.dev
wybe solve lamg/life-universe-everything
```

this creates the directory `problems/lamg/life-universe-everything` with an F# project
and the following files:

- `wybe.dev.fsproj`: F# project for this solution.
- `Solution.fs`: File where you are going to implement your solution.
It contains a `main: string seq -> string seq` function that is the main entry point
for testing your solution.
- `Test.fs`: Test cases for your solution
- `README.md`: Problem specification

now you can open that directory with your favorite IDE and start developing
your solution.

### Registering our results

Once we finish development we can upload our changes to our `wybe.dev` repository
in GitHub. This will trigger a GitHub Action that will test our solution and
record the results in https://wybe.dev.

### Creating a problem

Execute the command `wybe create -n PROBLEM_NAME` in the `wybe.dev` root path.
This will create a new project in `problems/PROBLEM_NAME` which you can modify
accordingly.