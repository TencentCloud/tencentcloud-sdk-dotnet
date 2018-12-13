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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetDetectInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonProperty("BizToken")]
        public string BizToken{ get; set; }

        /// <summary>
        /// 规则Id。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 指定需要拉取何种信息（0：全部；1：文本类；2：身份证正反面；3：截帧（最佳帧）；4：视频）。可拼接。如 134表示拉取文本类、截帧（最佳帧）、视频
        /// </summary>
        [JsonProperty("InfoType")]
        public string InfoType{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizToken", this.BizToken);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "InfoType", this.InfoType);
        }
    }
}

