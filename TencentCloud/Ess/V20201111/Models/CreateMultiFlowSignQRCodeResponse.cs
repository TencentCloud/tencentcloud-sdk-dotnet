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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMultiFlowSignQRCodeResponse : AbstractModel
    {
        
        /// <summary>
        /// 一码多签签署码的基本信息，用户可扫描该二维码进行签署操作。
        /// </summary>
        [JsonProperty("QrCode")]
        public SignQrCode QrCode{ get; set; }

        /// <summary>
        /// 一码多签签署码的链接信息，适用于客户系统整合二维码功能。通过链接，用户可直接访问电子签名小程序并签署合同。
        /// </summary>
        [JsonProperty("SignUrls")]
        public SignUrl SignUrls{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "QrCode.", this.QrCode);
            this.SetParamObj(map, prefix + "SignUrls.", this.SignUrls);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

