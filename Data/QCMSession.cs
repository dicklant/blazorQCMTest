namespace blazorQCMTest.Data;

public enum QCMSessionType {
    Quiz, Sondage
}

public enum QCMQuestionType {
    qcu, qcm, smile, rating
}

public class QCMSession {
    public int id {get; set;}

    public QCMSessionType typeSession {get; set;}

    public DateTime created {get; set; }

    public DateTime modified {get; set;}
}

public class QCMQuestion {
    public int id {get; set; }

    public string? question { get; set; }

    public QCMQuestionType typeQuestion {get; set; }

    public List<string>? choix {get; set;}

    public List<int>? reponses {get; set;}
}