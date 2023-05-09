import { fieldsProxy } from "@serenity-is/corelib/q";

export interface QuestionRow {
    QuestionId?: number;
    QuestionTitle?: string;
    OptionA?: string;
    OptionB?: string;
    OptionC?: string;
    OptionD?: string;
    AnswerKey?: number;
    Status?: boolean;
    CreatedDate?: string;
    ExamId?: number;
    ExamName?: string;
}

export abstract class QuestionRow {
    static readonly idProperty = 'QuestionId';
    static readonly nameProperty = 'QuestionTitle';
    static readonly localTextPrefix = 'School.Question';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<QuestionRow>();
}