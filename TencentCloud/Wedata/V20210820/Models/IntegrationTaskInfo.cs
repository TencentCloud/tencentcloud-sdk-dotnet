/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntegrationTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>任务描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>同步类型1.解决方案(整库迁移),2.单表同步</p>
        /// </summary>
        [JsonProperty("SyncType")]
        public long? SyncType{ get; set; }

        /// <summary>
        /// <p>201.实时,202.离线</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// <p>任务所属工作流id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>任务id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务调度id(oceanus or us等作业id)，非填项</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleTaskId")]
        public string ScheduleTaskId{ get; set; }

        /// <summary>
        /// <p>inlong任务id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskGroupId")]
        public string TaskGroupId{ get; set; }

        /// <summary>
        /// <p>项目id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>创建人uin</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// <p>操作人uin</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperatorUin")]
        public string OperatorUin{ get; set; }

        /// <summary>
        /// <p>owner uin</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>应用id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>0:新建(任务开发态默认状态)|1:未开始|2:操作中|3:运行中|4:暂停|5:任务停止中|6:停止|7:执行失败|20:异常|21:未知|</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>节点列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nodes")]
        public IntegrationNodeInfo[] Nodes{ get; set; }

        /// <summary>
        /// <p>执行资源id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorId")]
        public string ExecutorId{ get; set; }

        /// <summary>
        /// <p>任务配置信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Config")]
        public RecordField[] Config{ get; set; }

        /// <summary>
        /// <p>任务扩展配置信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtConfig")]
        public RecordField[] ExtConfig{ get; set; }

        /// <summary>
        /// <p>任务执行context信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecuteContext")]
        public RecordField[] ExecuteContext{ get; set; }

        /// <summary>
        /// <p>节点映射</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mappings")]
        public IntegrationNodeMapping[] Mappings{ get; set; }

        /// <summary>
        /// <p>任务配置模式，0:画布 1:表单 3:脚本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskMode")]
        public string TaskMode{ get; set; }

        /// <summary>
        /// <p>责任人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Incharge")]
        public string Incharge{ get; set; }

        /// <summary>
        /// <p>离线新增参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineTaskAddEntity")]
        public OfflineTaskAddParam OfflineTaskAddEntity{ get; set; }

        /// <summary>
        /// <p>group name</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupName")]
        public string ExecutorGroupName{ get; set; }

        /// <summary>
        /// <p>inlong manager url</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InLongManagerUrl")]
        public string InLongManagerUrl{ get; set; }

        /// <summary>
        /// <p>stream id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InLongStreamId")]
        public string InLongStreamId{ get; set; }

        /// <summary>
        /// <p>version</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InLongManagerVersion")]
        public string InLongManagerVersion{ get; set; }

        /// <summary>
        /// <p>inlong dataproxy url</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataProxyUrl")]
        public string[] DataProxyUrl{ get; set; }

        /// <summary>
        /// <p>任务版本是否已提交运维</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Submit")]
        public bool? Submit{ get; set; }

        /// <summary>
        /// <p>数据源类型：MYSQL|POSTGRE|ORACLE|SQLSERVER|FTP|HIVE|HDFS|ICEBERG|KAFKA|HBASE|SPARK|VIRTUAL|TBASE|DB2|DM|GAUSSDB|GBASE|IMPALA|ES|S3_DATAINSIGHT|GREENPLUM|PHOENIX|SAP_HANA|SFTP|OCEANBASE|CLICKHOUSE|KUDU|VERTICA|REDIS|COS|DLC|DLCV1|DORIS|CKAFKA|DTS_KAFKA|S3|CDW|LOCAL|TDSQLC|TDSQL|TDSQL_MYSQL|MONGODB|INFORMIX|SYBASE|REST_API|SuperSQL|PRESTO|DR_SUM|TiDB|StarRocks|Trino|Kyuubi|GDB|TCHOUSE_X|TCHOUSE_P|TDSQL_POSTGRE</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputDatasourceType")]
        public string InputDatasourceType{ get; set; }

        /// <summary>
        /// <p>数据源类型：MYSQL|POSTGRE|ORACLE|SQLSERVER|FTP|HIVE|HDFS|ICEBERG|KAFKA|HBASE|SPARK|VIRTUAL|TBASE|DB2|DM|GAUSSDB|GBASE|IMPALA|ES|S3_DATAINSIGHT|GREENPLUM|PHOENIX|SAP_HANA|SFTP|OCEANBASE|CLICKHOUSE|KUDU|VERTICA|REDIS|COS|DLC|DLCV1|DORIS|CKAFKA|DTS_KAFKA|S3|CDW|LOCAL|TDSQLC|TDSQL|TDSQL_MYSQL|MONGODB|INFORMIX|SYBASE|REST_API|SuperSQL|PRESTO|DR_SUM|TiDB|StarRocks|Trino|Kyuubi|GDB|TCHOUSE_X|TCHOUSE_P|TDSQL_POSTGRE</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputDatasourceType")]
        public string OutputDatasourceType{ get; set; }

        /// <summary>
        /// <p>读取条数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumRecordsIn")]
        public long? NumRecordsIn{ get; set; }

        /// <summary>
        /// <p>写入条数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumRecordsOut")]
        public long? NumRecordsOut{ get; set; }

        /// <summary>
        /// <p>读取延迟</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReaderDelay")]
        public float? ReaderDelay{ get; set; }

        /// <summary>
        /// <p>重启次数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumRestarts")]
        public long? NumRestarts{ get; set; }

        /// <summary>
        /// <p>任务创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>任务更新时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>任务最后一次运行时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastRunTime")]
        public string LastRunTime{ get; set; }

        /// <summary>
        /// <p>任务停止时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StopTime")]
        public string StopTime{ get; set; }

        /// <summary>
        /// <p>作业是否已提交</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasVersion")]
        public bool? HasVersion{ get; set; }

        /// <summary>
        /// <p>任务是否被锁定</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Locked")]
        public bool? Locked{ get; set; }

        /// <summary>
        /// <p>任务锁定人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Locker")]
        public string Locker{ get; set; }

        /// <summary>
        /// <p>耗费资源量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningCu")]
        public float? RunningCu{ get; set; }

        /// <summary>
        /// <p>该任务关联的告警规则</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskAlarmRegularList")]
        public string[] TaskAlarmRegularList{ get; set; }

        /// <summary>
        /// <p>实时任务资源分层情况： 0：进行中,1：成功 ,2：失败</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SwitchResource")]
        public long? SwitchResource{ get; set; }

        /// <summary>
        /// <p>实时任务读取阶段：0：全部全量,1：部分全量,2：全部增量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReadPhase")]
        public long? ReadPhase{ get; set; }

        /// <summary>
        /// <p>实时任务版本号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceVersion")]
        public long? InstanceVersion{ get; set; }

        /// <summary>
        /// <p>离线任务导入到编排空间的任务id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ArrangeSpaceTaskId")]
        public string ArrangeSpaceTaskId{ get; set; }

        /// <summary>
        /// <p>离线任务状态区分1.未提交2.已提交3.已导出</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineTaskStatus")]
        public long? OfflineTaskStatus{ get; set; }

        /// <summary>
        /// <p>导入到编排空间配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskImportInfo")]
        public TaskImportInfo TaskImportInfo{ get; set; }

        /// <summary>
        /// <p>业务延迟</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessLatency")]
        public long? BusinessLatency{ get; set; }

        /// <summary>
        /// <p>当前同步位点</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentSyncPosition")]
        public long? CurrentSyncPosition{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagList")]
        public IntegrationTag[] TagList{ get; set; }

        /// <summary>
        /// <p>错误信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// <p>任务子状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskSubType")]
        public long? TaskSubType{ get; set; }

        /// <summary>
        /// <p>是否存在SavePoint, 0-存在, 1-不存在, null 为未知</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotExistsCheckPoint")]
        public long? NotExistsCheckPoint{ get; set; }

        /// <summary>
        /// <p>savepiontPath</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SavePointId")]
        public string SavePointId{ get; set; }

        /// <summary>
        /// <p>savepiontId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SavePointPath")]
        public string SavePointPath{ get; set; }

        /// <summary>
        /// <p>最近一次操作信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastOperateInfo")]
        public LastOperateInfo LastOperateInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SyncType", this.SyncType);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "ScheduleTaskId", this.ScheduleTaskId);
            this.SetParamSimple(map, prefix + "TaskGroupId", this.TaskGroupId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "OperatorUin", this.OperatorUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Nodes.", this.Nodes);
            this.SetParamSimple(map, prefix + "ExecutorId", this.ExecutorId);
            this.SetParamArrayObj(map, prefix + "Config.", this.Config);
            this.SetParamArrayObj(map, prefix + "ExtConfig.", this.ExtConfig);
            this.SetParamArrayObj(map, prefix + "ExecuteContext.", this.ExecuteContext);
            this.SetParamArrayObj(map, prefix + "Mappings.", this.Mappings);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamSimple(map, prefix + "Incharge", this.Incharge);
            this.SetParamObj(map, prefix + "OfflineTaskAddEntity.", this.OfflineTaskAddEntity);
            this.SetParamSimple(map, prefix + "ExecutorGroupName", this.ExecutorGroupName);
            this.SetParamSimple(map, prefix + "InLongManagerUrl", this.InLongManagerUrl);
            this.SetParamSimple(map, prefix + "InLongStreamId", this.InLongStreamId);
            this.SetParamSimple(map, prefix + "InLongManagerVersion", this.InLongManagerVersion);
            this.SetParamArraySimple(map, prefix + "DataProxyUrl.", this.DataProxyUrl);
            this.SetParamSimple(map, prefix + "Submit", this.Submit);
            this.SetParamSimple(map, prefix + "InputDatasourceType", this.InputDatasourceType);
            this.SetParamSimple(map, prefix + "OutputDatasourceType", this.OutputDatasourceType);
            this.SetParamSimple(map, prefix + "NumRecordsIn", this.NumRecordsIn);
            this.SetParamSimple(map, prefix + "NumRecordsOut", this.NumRecordsOut);
            this.SetParamSimple(map, prefix + "ReaderDelay", this.ReaderDelay);
            this.SetParamSimple(map, prefix + "NumRestarts", this.NumRestarts);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LastRunTime", this.LastRunTime);
            this.SetParamSimple(map, prefix + "StopTime", this.StopTime);
            this.SetParamSimple(map, prefix + "HasVersion", this.HasVersion);
            this.SetParamSimple(map, prefix + "Locked", this.Locked);
            this.SetParamSimple(map, prefix + "Locker", this.Locker);
            this.SetParamSimple(map, prefix + "RunningCu", this.RunningCu);
            this.SetParamArraySimple(map, prefix + "TaskAlarmRegularList.", this.TaskAlarmRegularList);
            this.SetParamSimple(map, prefix + "SwitchResource", this.SwitchResource);
            this.SetParamSimple(map, prefix + "ReadPhase", this.ReadPhase);
            this.SetParamSimple(map, prefix + "InstanceVersion", this.InstanceVersion);
            this.SetParamSimple(map, prefix + "ArrangeSpaceTaskId", this.ArrangeSpaceTaskId);
            this.SetParamSimple(map, prefix + "OfflineTaskStatus", this.OfflineTaskStatus);
            this.SetParamObj(map, prefix + "TaskImportInfo.", this.TaskImportInfo);
            this.SetParamSimple(map, prefix + "BusinessLatency", this.BusinessLatency);
            this.SetParamSimple(map, prefix + "CurrentSyncPosition", this.CurrentSyncPosition);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "TaskSubType", this.TaskSubType);
            this.SetParamSimple(map, prefix + "NotExistsCheckPoint", this.NotExistsCheckPoint);
            this.SetParamSimple(map, prefix + "SavePointId", this.SavePointId);
            this.SetParamSimple(map, prefix + "SavePointPath", this.SavePointPath);
            this.SetParamObj(map, prefix + "LastOperateInfo.", this.LastOperateInfo);
        }
    }
}

