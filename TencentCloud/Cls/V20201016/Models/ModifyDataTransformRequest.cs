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

    public class ModifyDataTransformRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据加工任务ID
        /// - 通过[获取数据加工任务列表基本信息](https://cloud.tencent.com/document/product/614/72182)获取数据加工任务Id。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 加工任务名称
        /// - 通过[获取数据加工任务列表基本信息](https://cloud.tencent.com/document/product/614/72182)获取数据加工任务名称。
        /// 
        /// 名称限制
        /// - 不能为空字符串
        /// - 不能包含字符'|'
        /// - 最长 255 个字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 加工语句。 当FuncType为2时，EtlContent必须使用[log_auto_output](https://cloud.tencent.com/document/product/614/70733#b3c58797-4825-4807-bef4-68106e25024f) 
        /// 
        /// 其他参考文档：
        /// 
        /// - [创建加工任务](https://cloud.tencent.com/document/product/614/63940) 
        /// -  [函数总览](https://cloud.tencent.com/document/product/614/70395)
        /// </summary>
        [JsonProperty("EtlContent")]
        public string EtlContent{ get; set; }

        /// <summary>
        /// 任务启动状态. 默认为1，开启,  2关闭
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// 加工任务目的topic_id以及别名
        /// </summary>
        [JsonProperty("DstResources")]
        public DataTransformResouceInfo[] DstResources{ get; set; }

        /// <summary>
        /// 超限之后是否丢弃日志数据
        /// </summary>
        [JsonProperty("BackupGiveUpData")]
        public bool? BackupGiveUpData{ get; set; }

        /// <summary>
        /// 是否开启投递服务日志。1关闭，2开启
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

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
        /// 外部数据源信息
        /// </summary>
        [JsonProperty("DataTransformSqlDataSources")]
        public DataTransformSqlDataSource[] DataTransformSqlDataSources{ get; set; }

        /// <summary>
        /// 设置的环境变量
        /// </summary>
        [JsonProperty("EnvInfos")]
        public EnvInfo[] EnvInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EtlContent", this.EtlContent);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamArrayObj(map, prefix + "DstResources.", this.DstResources);
            this.SetParamSimple(map, prefix + "BackupGiveUpData", this.BackupGiveUpData);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
            this.SetParamSimple(map, prefix + "KeepFailureLog", this.KeepFailureLog);
            this.SetParamSimple(map, prefix + "FailureLogKey", this.FailureLogKey);
            this.SetParamArrayObj(map, prefix + "DataTransformSqlDataSources.", this.DataTransformSqlDataSources);
            this.SetParamArrayObj(map, prefix + "EnvInfos.", this.EnvInfos);
        }
    }
}

