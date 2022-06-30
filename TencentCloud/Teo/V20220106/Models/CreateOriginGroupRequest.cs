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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOriginGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 源站组名称
        /// </summary>
        [JsonProperty("OriginName")]
        public string OriginName{ get; set; }

        /// <summary>
        /// 配置类型，当OriginType=self 时，需要填写：
        /// area: 按区域配置
        /// weight: 按权重配置
        /// 当OriginType=third_party/cos 时，不需要填写
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 源站记录
        /// </summary>
        [JsonProperty("Record")]
        public OriginRecord[] Record{ get; set; }

        /// <summary>
        /// 站点ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 源站类型
        /// self：自有源站
        /// third_party：第三方源站
        /// cos：腾讯云COS源站
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginName", this.OriginName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Record.", this.Record);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
        }
    }
}

