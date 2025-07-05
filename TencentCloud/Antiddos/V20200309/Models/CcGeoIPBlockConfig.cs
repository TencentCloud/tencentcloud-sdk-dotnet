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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CcGeoIPBlockConfig : AbstractModel
    {
        
        /// <summary>
        /// 区域类型，取值[
        /// oversea(境外)
        /// china(国内)
        /// customized(自定义地区)
        /// ]
        /// </summary>
        [JsonProperty("RegionType")]
        public string RegionType{ get; set; }

        /// <summary>
        /// 封禁动作，取值[
        /// drop(拦截)
        /// alg(人机校验)
        /// ]
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 配置ID，配置添加成功后生成；添加新配置时不用填写此字段，修改或删除配置时需要填写配置ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 当RegionType为customized时，必须填写AreaList；当RegionType为china或oversea时，AreaList为空
        /// </summary>
        [JsonProperty("AreaList")]
        public long?[] AreaList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionType", this.RegionType);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "AreaList.", this.AreaList);
        }
    }
}

