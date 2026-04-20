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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDatahubTaskRes : AbstractModel
    {
        
        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>任务类型，SOURCE数据接入，SINK数据流出</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>状态，-1创建失败，0创建中，1运行中，2删除中，3已删除，4删除失败，5暂停中，6已暂停，7暂停失败，8恢复中，9恢复失败</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>数据源</p>
        /// </summary>
        [JsonProperty("SourceResource")]
        public DatahubResource SourceResource{ get; set; }

        /// <summary>
        /// <p>数据目标</p>
        /// </summary>
        [JsonProperty("TargetResource")]
        public DatahubResource TargetResource{ get; set; }

        /// <summary>
        /// <p>Connection列表</p>
        /// </summary>
        [JsonProperty("Connections")]
        public Connection[] Connections{ get; set; }

        /// <summary>
        /// <p>任务创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>消息处理规则</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransformParam")]
        public TransformParam TransformParam{ get; set; }

        /// <summary>
        /// <p>数据接入ID</p>
        /// </summary>
        [JsonProperty("DatahubId")]
        public string DatahubId{ get; set; }

        /// <summary>
        /// <p>绑定的SchemaId</p>
        /// </summary>
        [JsonProperty("SchemaId")]
        public string SchemaId{ get; set; }

        /// <summary>
        /// <p>绑定的Schema名称</p>
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// <p>数据处理规则</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransformsParam")]
        public TransformsParam TransformsParam{ get; set; }

        /// <summary>
        /// <p>异常信息</p>
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// <p>任务标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>任务描述信息</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>1:正常 2:隔离中</p>
        /// </summary>
        [JsonProperty("IsolateStatus")]
        public long? IsolateStatus{ get; set; }

        /// <summary>
        /// <p>并发数</p><p>默认值：1</p>
        /// </summary>
        [JsonProperty("TaskMax")]
        public long? TaskMax{ get; set; }

        /// <summary>
        /// <p>并发流量预估参考上限，MB/s</p>
        /// </summary>
        [JsonProperty("SyncThrottleLimit")]
        public long? SyncThrottleLimit{ get; set; }

        /// <summary>
        /// <p>自动扩容 true:自动扩容 false:手动扩容</p><p>默认值：true</p>
        /// </summary>
        [JsonProperty("AutoExpandFlag")]
        public bool? AutoExpandFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "SourceResource.", this.SourceResource);
            this.SetParamObj(map, prefix + "TargetResource.", this.TargetResource);
            this.SetParamArrayObj(map, prefix + "Connections.", this.Connections);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "TransformParam.", this.TransformParam);
            this.SetParamSimple(map, prefix + "DatahubId", this.DatahubId);
            this.SetParamSimple(map, prefix + "SchemaId", this.SchemaId);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamObj(map, prefix + "TransformsParam.", this.TransformsParam);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsolateStatus", this.IsolateStatus);
            this.SetParamSimple(map, prefix + "TaskMax", this.TaskMax);
            this.SetParamSimple(map, prefix + "SyncThrottleLimit", this.SyncThrottleLimit);
            this.SetParamSimple(map, prefix + "AutoExpandFlag", this.AutoExpandFlag);
        }
    }
}

