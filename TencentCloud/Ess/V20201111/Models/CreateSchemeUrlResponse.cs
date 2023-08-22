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

    public class CreateSchemeUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 小程序链接地址，有效期90天。如果EndPoint是App，得到的链接Path如’weixin://dl/business/?t= *TICKET*‘，用于客户APP、小程序直接拉起电子签小程序；其他EndPoint得到的https链接如'https://essurl.cn/xxx'，点击链接会打开一个H5页面，然后拉起电子签小程序。
        /// </summary>
        [JsonProperty("SchemeUrl")]
        public string SchemeUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "SchemeUrl", this.SchemeUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

