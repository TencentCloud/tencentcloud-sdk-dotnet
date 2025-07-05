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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyResourceTags : AbstractModel
    {
        
        /// <summary>
        /// 集群id 或者 cvm id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源6段式表达式
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// 资源前缀
        /// </summary>
        [JsonProperty("ResourcePrefix")]
        public string ResourcePrefix{ get; set; }

        /// <summary>
        /// ap-beijing
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// emr
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 删除的标签列表
        /// </summary>
        [JsonProperty("DeleteTags")]
        public Tag[] DeleteTags{ get; set; }

        /// <summary>
        /// 添加的标签列表
        /// </summary>
        [JsonProperty("AddTags")]
        public Tag[] AddTags{ get; set; }

        /// <summary>
        /// 修改的标签列表
        /// </summary>
        [JsonProperty("ModifyTags")]
        public Tag[] ModifyTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "ResourcePrefix", this.ResourcePrefix);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamArrayObj(map, prefix + "DeleteTags.", this.DeleteTags);
            this.SetParamArrayObj(map, prefix + "AddTags.", this.AddTags);
            this.SetParamArrayObj(map, prefix + "ModifyTags.", this.ModifyTags);
        }
    }
}

