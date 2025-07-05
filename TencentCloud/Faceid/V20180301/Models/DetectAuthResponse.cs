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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectAuthResponse : AbstractModel
    {
        
        /// <summary>
        /// 用于发起核身流程的URL，仅微信H5场景使用。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 一次核验流程的唯一标识。
        /// - 有效时间为7,200秒，超过有效期再进行人脸核验会报错，请在有效期内进行核验。
        /// - 完成人脸核验后，需根据此标识调用[获取实名核身结果信息增强版](https://cloud.tencent.com/document/api/1007/41957)获取用户最终验证结果信息。
        /// </summary>
        [JsonProperty("BizToken")]
        public string BizToken{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "BizToken", this.BizToken);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

