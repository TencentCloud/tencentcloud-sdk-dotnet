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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteCloudRunVersionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境 Id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 是否删除服务，只有最后一个版本的时候才生效
        /// </summary>
        [JsonProperty("IsDeleteServer")]
        public bool? IsDeleteServer{ get; set; }

        /// <summary>
        /// 只有删除服务的时候，才生效
        /// </summary>
        [JsonProperty("IsDeleteImage")]
        public bool? IsDeleteImage{ get; set; }

        /// <summary>
        /// 删除版本的信息
        /// </summary>
        [JsonProperty("SimpleVersions")]
        public SimpleVersion[] SimpleVersions{ get; set; }

        /// <summary>
        /// 操作备注
        /// </summary>
        [JsonProperty("OperatorRemark")]
        public string OperatorRemark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "IsDeleteServer", this.IsDeleteServer);
            this.SetParamSimple(map, prefix + "IsDeleteImage", this.IsDeleteImage);
            this.SetParamArrayObj(map, prefix + "SimpleVersions.", this.SimpleVersions);
            this.SetParamSimple(map, prefix + "OperatorRemark", this.OperatorRemark);
        }
    }
}

