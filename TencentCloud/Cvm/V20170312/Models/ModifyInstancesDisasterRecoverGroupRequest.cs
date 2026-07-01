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

    public class ModifyInstancesDisasterRecoverGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>一个或多个待操作的实例ID。可通过<a href="https://cloud.tencent.com/document/api/213/15728"> DescribeInstances </a>接口返回值中的<code>InstanceId</code>获取。每次请求批量实例的上限为100</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>分散置放群组ID，可使用<a href="https://cloud.tencent.com/document/api/213/17810">DescribeDisasterRecoverGroups</a>接口获取</p>
        /// </summary>
        [JsonProperty("DisasterRecoverGroupId")]
        [System.Obsolete]
        public string DisasterRecoverGroupId{ get; set; }

        /// <summary>
        /// <p>是否强制更换实例宿主机。取值范围：<br><li>true：表示允许实例更换宿主机，允许重启实例。本地盘子机不支持指定此参数。</li><br><li>false：不允许实例更换宿主机，只在当前宿主机上加入置放群组。这可能导致更换置放群组失败。</li><br><br>默认取值：false</p>
        /// </summary>
        [JsonProperty("Force")]
        public bool? Force{ get; set; }

        /// <summary>
        /// <p>置放群组id列表(目前仅支持指定一个)</p>
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// <p>分区置放群组的分区Id，取值范围：1-10，具体取决于所选置放群组的分区数量，如果选中的置放群组是分区置放群组，该值不传默认随机(该功能灰度中)</p>
        /// </summary>
        [JsonProperty("PartitionNumber")]
        public long? PartitionNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "DisasterRecoverGroupId", this.DisasterRecoverGroupId);
            this.SetParamSimple(map, prefix + "Force", this.Force);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamSimple(map, prefix + "PartitionNumber", this.PartitionNumber);
        }
    }
}

