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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisplayJobRecord : AbstractModel
    {
        
        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CustomerId")]
        public long? CustomerId{ get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// 周期任务详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Crontab")]
        public string Crontab{ get; set; }

        /// <summary>
        /// 状态：2-错误/已停止，3-进行中，1-已完成, 4-停止
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 新增数据
        /// </summary>
        [JsonProperty("NewCount")]
        public long? NewCount{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateAt")]
        public string UpdateAt{ get; set; }

        /// <summary>
        /// 子任务进度
        /// </summary>
        [JsonProperty("Progress")]
        public JobRecordProgress Progress{ get; set; }

        /// <summary>
        /// 并发设置
        /// </summary>
        [JsonProperty("Qps")]
        public long? Qps{ get; set; }

        /// <summary>
        /// 任务类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 客户Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 客户appid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamSimple(map, prefix + "Crontab", this.Crontab);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "NewCount", this.NewCount);
            this.SetParamSimple(map, prefix + "CreateAt", this.CreateAt);
            this.SetParamSimple(map, prefix + "UpdateAt", this.UpdateAt);
            this.SetParamObj(map, prefix + "Progress.", this.Progress);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
        }
    }
}

