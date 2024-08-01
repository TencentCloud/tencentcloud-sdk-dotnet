/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputDescribeDataListFront : AbstractModel
    {
        
        /// <summary>
        /// 名单数据ID
        /// </summary>
        [JsonProperty("NameListDataId")]
        public long? NameListDataId{ get; set; }

        /// <summary>
        /// 名单ID
        /// </summary>
        [JsonProperty("NameListId")]
        public long? NameListId{ get; set; }

        /// <summary>
        /// 名单数据内容
        /// </summary>
        [JsonProperty("DataContent")]
        public string DataContent{ get; set; }

        /// <summary>
        /// 数据来源，固定传2（手工录入）
        /// </summary>
        [JsonProperty("DataSource")]
        public long? DataSource{ get; set; }

        /// <summary>
        /// 名单数据开始时间，时间格式示例"2024-05-05 12:10:15"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 名单数据结束时间，时间格式示例"2024-05-05 12:10:15"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 名单数据状态 [1 启用 2 停用]
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 名单数据描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 名单数据创建时间，时间格式示例"2024-05-05 12:10:15"
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 名单数据更新时间，时间格式示例"2024-05-05 12:10:15"
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 加密名单数据内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncryptDataContent")]
        public string EncryptDataContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NameListDataId", this.NameListDataId);
            this.SetParamSimple(map, prefix + "NameListId", this.NameListId);
            this.SetParamSimple(map, prefix + "DataContent", this.DataContent);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "EncryptDataContent", this.EncryptDataContent);
        }
    }
}

