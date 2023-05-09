import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface ExamRow {
    ExamId?: number;
    Name?: string;
    Description?: string;
    Time?: number;
    Status?: boolean;
    CreatedDate?: string;
}

export abstract class ExamRow {
    static readonly idProperty = 'ExamId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'School.Exam';
    static readonly lookupKey = 'School.Exam';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ExamRow>('School.Exam') }
    static async getLookupAsync() { return getLookupAsync<ExamRow>('School.Exam') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamRow>();
}