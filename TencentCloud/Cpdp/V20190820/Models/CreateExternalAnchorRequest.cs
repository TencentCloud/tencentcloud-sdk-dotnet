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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateExternalAnchorRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台业务系统唯一标示的主播id
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// 主播名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("IdNo")]
        public string IdNo{ get; set; }

        /// <summary>
        /// 身份证正面图片下载链接
        /// </summary>
        [JsonProperty("IdCardFront")]
        public string IdCardFront{ get; set; }

        /// <summary>
        /// 身份证反面图片下载链接
        /// </summary>
        [JsonProperty("IdCardReverse")]
        public string IdCardReverse{ get; set; }

        /// <summary>
        /// 指定分配的代理商ID
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdNo", this.IdNo);
            this.SetParamSimple(map, prefix + "IdCardFront", this.IdCardFront);
            this.SetParamSimple(map, prefix + "IdCardReverse", this.IdCardReverse);
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
        }
    }
}

