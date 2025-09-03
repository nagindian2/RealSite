export interface IFileReassign {
    reassign_detail_id: number;
    request_id: number;
    reassign_from_id?: number;
    reassign_to_id: number;
    reassign_from_name?: string;
    reassign_to_name?: string;
    reassign_type: string;
    created_by: number;
    created_on: Date;
    updated_by?: number;
    updated_on?: Date;
  }
