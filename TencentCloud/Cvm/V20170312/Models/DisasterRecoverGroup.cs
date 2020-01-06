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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisasterRecoverGroup : AbstractModel
    {
        
        /// <summary>
        /// 分散置放群组id。
        /// </summary>
        [JsonProperty("DisasterRecoverGroupId")]
        public string DisasterRecoverGroupId{ get; set; }

        /// <summary>
        /// 分散置放群组名称，长度1-60个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 分散置放群组类型，取值范围：<br><li>HOST：物理机<br><li>SW：交换机<br><li>RACK：机架
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 分散置放群组内最大容纳云服务器数量。
        /// </summary>
        [JsonProperty("CvmQuotaTotal")]
        public long? CvmQuotaTotal{ get; set; }

        /// <summary>
        /// 分散置放群组内云服务器当前数量。
        /// </summary>
        [JsonProperty("CurrentNum")]
        public long? CurrentNum{ get; set; }

        /// <summary>
        /// 分散置放群组内，云服务器id列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 分散置放群组创建时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisasterRecoverGroupId", this.DisasterRecoverGroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CvmQuotaTotal", this.CvmQuotaTotal);
            this.SetParamSimple(map, prefix + "CurrentNum", this.CurrentNum);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

