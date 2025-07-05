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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VpcFwInstance : AbstractModel
    {
        
        /// <summary>
        /// 防火墙实例名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 私有网络模式下接入的VpcId列表；仅私有网络模式使用
        /// </summary>
        [JsonProperty("VpcIds")]
        public string[] VpcIds{ get; set; }

        /// <summary>
        /// 部署地域信息
        /// </summary>
        [JsonProperty("FwDeploy")]
        public FwDeploy FwDeploy{ get; set; }

        /// <summary>
        /// 防火墙实例ID (编辑场景传)
        /// </summary>
        [JsonProperty("FwInsId")]
        public string FwInsId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "VpcIds.", this.VpcIds);
            this.SetParamObj(map, prefix + "FwDeploy.", this.FwDeploy);
            this.SetParamSimple(map, prefix + "FwInsId", this.FwInsId);
        }
    }
}

