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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtensionFileInfo : AbstractModel
    {
        
        /// <summary>
        /// 模板里使用的地址
        /// </summary>
        [JsonProperty("CodeUri")]
        public string CodeUri{ get; set; }

        /// <summary>
        /// 上传文件的临时地址，含签名
        /// </summary>
        [JsonProperty("UploadUrl")]
        public string UploadUrl{ get; set; }

        /// <summary>
        /// 自定义密钥。如果为空，则表示不需要加密。
        /// 参考cos预签名url上传https://cloud.tencent.com/document/product/436/36121
        /// 上传的时候要按照 SSE-C 的方式设置header：https://cloud.tencent.com/document/product/436/7728
        /// </summary>
        [JsonProperty("CustomKey")]
        public string CustomKey{ get; set; }

        /// <summary>
        /// 文件大小限制，单位M，客户端上传前需要主动检查文件大小，超过限制的文件会被删除。
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CodeUri", this.CodeUri);
            this.SetParamSimple(map, prefix + "UploadUrl", this.UploadUrl);
            this.SetParamSimple(map, prefix + "CustomKey", this.CustomKey);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
        }
    }
}

