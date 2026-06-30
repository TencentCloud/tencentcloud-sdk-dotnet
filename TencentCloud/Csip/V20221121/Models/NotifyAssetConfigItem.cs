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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NotifyAssetConfigItem : AbstractModel
    {
        
        /// <summary>
        /// <p>模块名</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>子模块</p>
        /// </summary>
        [JsonProperty("SubModule")]
        public string SubModule{ get; set; }

        /// <summary>
        /// <p>资产范围</p><p>枚举值：</p><ul><li>0： 无含义</li><li>1： 全部</li><li>2： 自选</li><li>3： 按标签</li></ul>
        /// </summary>
        [JsonProperty("AssetRange")]
        public long? AssetRange{ get; set; }

        /// <summary>
        /// <p>选中的实例ID</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>剔除的实例ID</p>
        /// </summary>
        [JsonProperty("ExcludedInstanceIds")]
        public string[] ExcludedInstanceIds{ get; set; }

        /// <summary>
        /// <p>标签ID</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public long?[] TagIds{ get; set; }

        /// <summary>
        /// <p>云标签</p>
        /// </summary>
        [JsonProperty("CloudTags")]
        public string[] CloudTags{ get; set; }

        /// <summary>
        /// <p>总数</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "SubModule", this.SubModule);
            this.SetParamSimple(map, prefix + "AssetRange", this.AssetRange);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "ExcludedInstanceIds.", this.ExcludedInstanceIds);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
            this.SetParamArraySimple(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
        }
    }
}

