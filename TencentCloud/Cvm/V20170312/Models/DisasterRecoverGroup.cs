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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisasterRecoverGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>分散置放群组id。</p>
        /// </summary>
        [JsonProperty("DisasterRecoverGroupId")]
        public string DisasterRecoverGroupId{ get; set; }

        /// <summary>
        /// <p>分散置放群组名称，长度1-60个字符。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>分散置放群组类型，取值范围：<br></p><li>HOST：物理机<br></li><li>SW：交换机<br></li><li>RACK：机架</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>分散置放群组内最大容纳云服务器数量。</p>
        /// </summary>
        [JsonProperty("CvmQuotaTotal")]
        public long? CvmQuotaTotal{ get; set; }

        /// <summary>
        /// <p>分散置放群组内云服务器当前数量。</p>
        /// </summary>
        [JsonProperty("CurrentNum")]
        public long? CurrentNum{ get; set; }

        /// <summary>
        /// <p>分散置放群组内，云服务器id列表。</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>分散置放群组创建时间。按照<code>ISO8601</code>标准表示，并且使用<code>UTC</code>时间。格式为：<code>YYYY-MM-DDThh:mm:ssZ</code>。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>置放群组亲和度</p>
        /// </summary>
        [JsonProperty("Affinity")]
        public long? Affinity{ get; set; }

        /// <summary>
        /// <p>置放群组类型，当前支持两种；分散置放群组和分区置放群组(功能灰度中)，取值范围：PARTITION：分区置放群组，SPREAD：分散置放群组</p>
        /// </summary>
        [JsonProperty("Strategy")]
        public string Strategy{ get; set; }

        /// <summary>
        /// <p>分区置放群组的分区数量，如果是分区置放群组会返回(功能灰度中)</p>
        /// </summary>
        [JsonProperty("PartitionCount")]
        public long? PartitionCount{ get; set; }

        /// <summary>
        /// <p>置放群组关联的标签列表。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisasterRecoverGroupId", this.DisasterRecoverGroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CvmQuotaTotal", this.CvmQuotaTotal);
            this.SetParamSimple(map, prefix + "CurrentNum", this.CurrentNum);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Affinity", this.Affinity);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "PartitionCount", this.PartitionCount);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

