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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataTransformTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据加工任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 数据加工任务id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务启用状态，默认为1，正常开启,  2关闭
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// 加工任务类型，1： DSL(使用自定义加工语言的加工任务)， 2：SQL(使用sql的加工任务)
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 源日志主题
        /// </summary>
        [JsonProperty("SrcTopicId")]
        public string SrcTopicId{ get; set; }

        /// <summary>
        /// 当前加工任务状态（1准备中/2运行中/3停止中/4已停止）
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近修改时间
        /// 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 最后启用时间，如果需要重建集群，修改该时间
        /// 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("LastEnableTime")]
        public string LastEnableTime{ get; set; }

        /// <summary>
        /// 日志主题名称
        /// </summary>
        [JsonProperty("SrcTopicName")]
        public string SrcTopicName{ get; set; }

        /// <summary>
        /// 日志集id
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// 加工任务目的topic_id以及别名
        /// </summary>
        [JsonProperty("DstResources")]
        public DataTransformResouceInfo[] DstResources{ get; set; }

        /// <summary>
        /// 加工逻辑函数。
        /// </summary>
        [JsonProperty("EtlContent")]
        public string EtlContent{ get; set; }

        /// <summary>
        /// 兜底topic_id
        /// </summary>
        [JsonProperty("BackupTopicID")]
        public string BackupTopicID{ get; set; }

        /// <summary>
        /// 超限之后是否丢弃日志数据
        /// </summary>
        [JsonProperty("BackupGiveUpData")]
        public bool? BackupGiveUpData{ get; set; }

        /// <summary>
        /// 是否开启投递服务日志。 1关闭,2开启
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

        /// <summary>
        /// 任务目标日志主题数量
        /// </summary>
        [JsonProperty("TaskDstCount")]
        public ulong? TaskDstCount{ get; set; }

        /// <summary>
        /// 数据加工类型。0：标准加工任务；1：前置加工任务。
        /// </summary>
        [JsonProperty("DataTransformType")]
        public ulong? DataTransformType{ get; set; }

        /// <summary>
        /// 保留失败日志状态。 1:不保留，2:保留
        /// </summary>
        [JsonProperty("KeepFailureLog")]
        public ulong? KeepFailureLog{ get; set; }

        /// <summary>
        /// 失败日志的字段名称
        /// </summary>
        [JsonProperty("FailureLogKey")]
        public string FailureLogKey{ get; set; }

        /// <summary>
        /// 指定加工数据的开始时间，秒级时间戳。
        /// - 日志主题生命周期内的任意时间范围，如果超出了生命周期,只处理生命周期内有数据的部分。
        /// </summary>
        [JsonProperty("ProcessFromTimestamp")]
        public ulong? ProcessFromTimestamp{ get; set; }

        /// <summary>
        /// 指定加工数据的结束时间，秒级时间戳。
        /// 1. 不可指定未来的时间
        /// 2. 不填则表示持续执行
        /// </summary>
        [JsonProperty("ProcessToTimestamp")]
        public ulong? ProcessToTimestamp{ get; set; }

        /// <summary>
        /// sql数据源信息
        /// </summary>
        [JsonProperty("DataTransformSqlDataSources")]
        public DataTransformSqlDataSource[] DataTransformSqlDataSources{ get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        [JsonProperty("EnvInfos")]
        public EnvInfo[] EnvInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SrcTopicId", this.SrcTopicId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LastEnableTime", this.LastEnableTime);
            this.SetParamSimple(map, prefix + "SrcTopicName", this.SrcTopicName);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamArrayObj(map, prefix + "DstResources.", this.DstResources);
            this.SetParamSimple(map, prefix + "EtlContent", this.EtlContent);
            this.SetParamSimple(map, prefix + "BackupTopicID", this.BackupTopicID);
            this.SetParamSimple(map, prefix + "BackupGiveUpData", this.BackupGiveUpData);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
            this.SetParamSimple(map, prefix + "TaskDstCount", this.TaskDstCount);
            this.SetParamSimple(map, prefix + "DataTransformType", this.DataTransformType);
            this.SetParamSimple(map, prefix + "KeepFailureLog", this.KeepFailureLog);
            this.SetParamSimple(map, prefix + "FailureLogKey", this.FailureLogKey);
            this.SetParamSimple(map, prefix + "ProcessFromTimestamp", this.ProcessFromTimestamp);
            this.SetParamSimple(map, prefix + "ProcessToTimestamp", this.ProcessToTimestamp);
            this.SetParamArrayObj(map, prefix + "DataTransformSqlDataSources.", this.DataTransformSqlDataSources);
            this.SetParamArrayObj(map, prefix + "EnvInfos.", this.EnvInfos);
        }
    }
}

