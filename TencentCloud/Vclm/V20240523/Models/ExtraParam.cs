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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtraParam : AbstractModel
    {
        
        /// <summary>
        /// <p>预签名的上传url，支持把视频直接传到客户指定的地址。</p>
        /// </summary>
        [JsonProperty("UserDesignatedUrl")]
        public string UserDesignatedUrl{ get; set; }

        /// <summary>
        /// <p>回调地址<br>需要您在创建任务时主动设置 CallbackUrl，请求方法为 POST，当视频生成结束时，我们将向此地址发送生成结果。<br>数据格式如下：<br>{<br>    &quot;JobId&quot;: &quot;1397428070633955328&quot;,<br>    &quot;Status&quot;: &quot;DONE&quot;,<br>    &quot;ErrorCode&quot;: &quot;&quot;,<br>    &quot;ErrorMessage&quot;: &quot;&quot;,<br>    &quot;ResultVideoUrl&quot;: &quot;https://vcg.cos.tencentcos.cn/template_to_video/fa80b846-b933-4981-afad-8a39b46ef2ca.mp4&quot;<br>}</p>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// <p>BGM音频文本。</p>
        /// </summary>
        [JsonProperty("BGMText")]
        public string BGMText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserDesignatedUrl", this.UserDesignatedUrl);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "BGMText", this.BGMText);
        }
    }
}

