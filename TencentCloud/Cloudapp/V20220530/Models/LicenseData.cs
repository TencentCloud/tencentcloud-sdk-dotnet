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

namespace TencentCloud.Cloudapp.V20220530.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LicenseData : AbstractModel
    {
        
        /// <summary>
        /// <p>License 文本内容。支持密钥、证书等文本形式，二进制的密钥需要伙伴进行 base64 转码</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>部署服务输出信息，基于部署签发 License 时需要该参数。</p>
        /// </summary>
        [JsonProperty("DeploymentOutput")]
        public string DeploymentOutput{ get; set; }

        /// <summary>
        /// <p>License 前端展示信息。key、value 形式，比如可传入，颁发机构：XXXX 有限公司</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public DisplayMetadata[] Metadata{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "DeploymentOutput", this.DeploymentOutput);
            this.SetParamArrayObj(map, prefix + "Metadata.", this.Metadata);
        }
    }
}

