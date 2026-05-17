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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSealResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>电子印章ID，为32位字符串。<br>建议开发者保留此印章ID，后续指定签署区印章或者操作印章需此印章ID。<br>可登录腾讯电子签控制台，在 &quot;印章&quot;-&gt;&quot;印章中心&quot;选择查看的印章，在&quot;印章详情&quot; 中查看某个印章的SealId(在页面中展示为印章ID)。</p>
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// <p>电子印章预览链接地址，地址默认失效时间为24小时。</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>人脸验证操作人链接，用法可以参考&quot;<a href="https://qian.tencent.com/developers/company/openwxminiprogram/">跳转电子签小程序配置</a>&quot;，默认为空。</p>
        /// </summary>
        [JsonProperty("SealOperatorVerifyPath")]
        public string SealOperatorVerifyPath{ get; set; }

        /// <summary>
        /// <p>人脸验证操作人二维码链接，扫码后会跳转到腾讯电子签小程序进行人脸验证，默认为空。</p>
        /// </summary>
        [JsonProperty("SealOperatorVerifyQrcodeUrl")]
        public string SealOperatorVerifyQrcodeUrl{ get; set; }

        /// <summary>
        /// <p>创建印章预览逻辑，返回的是印章加盖在示例文件上的效果图片链接。链接有效期为90天。</p>
        /// </summary>
        [JsonProperty("PreviewFileUrl")]
        public string PreviewFileUrl{ get; set; }

        /// <summary>
        /// <p>创建印章预览逻辑，返回的是印章加盖在示例文件上的效果PDF文件链接。链接有效期为90天。</p>
        /// </summary>
        [JsonProperty("PreviewPdfUrl")]
        public string PreviewPdfUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "SealOperatorVerifyPath", this.SealOperatorVerifyPath);
            this.SetParamSimple(map, prefix + "SealOperatorVerifyQrcodeUrl", this.SealOperatorVerifyQrcodeUrl);
            this.SetParamSimple(map, prefix + "PreviewFileUrl", this.PreviewFileUrl);
            this.SetParamSimple(map, prefix + "PreviewPdfUrl", this.PreviewPdfUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

