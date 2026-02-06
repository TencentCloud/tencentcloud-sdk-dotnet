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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImportMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>待分析视频的URL，目前只支持<em>不带签名的</em>COS地址，字段输入内容最大为1KB</p>
        /// </summary>
        [JsonProperty("URL")]
        public string URL{ get; set; }

        /// <summary>
        /// <p>待分析视频的MD5，为空时不做校验，否则会做MD5校验，长度必须为32</p>
        /// </summary>
        [JsonProperty("MD5")]
        public string MD5{ get; set; }

        /// <summary>
        /// <p>待分析视频的名称，指定后可支持筛选，视频名称的大小长度不能超过64</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>当非本人外部视频地址导入时，该字段为转存的cos桶地址且不可为空; 示例：https://${Bucket}-${AppId}.cos.${Region}.myqcloud.com/${PathPrefix}/  (注意，cos路径需要以/分隔符结尾)。推荐采用本主账号COS桶，如果使用其他账号COS桶，请确保COS桶可写，否则可导致分析失败</p>
        /// </summary>
        [JsonProperty("WriteBackCosPath")]
        public string WriteBackCosPath{ get; set; }

        /// <summary>
        /// <p>自定义标签，可用于查询</p>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// <p>媒资导入完成的回调地址，该设置优先级高于控制台全局的设置；</p>
        /// </summary>
        [JsonProperty("CallbackURL")]
        public string CallbackURL{ get; set; }

        /// <summary>
        /// <p>媒资文件类型，详细定义参见<a href="https://cloud.tencent.com/document/product/1509/65063#MediaPreknownInfo">MediaPreknownInfo.MediaType</a><br>默认为2(视频)</p>
        /// </summary>
        [JsonProperty("MediaType")]
        public long? MediaType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "URL", this.URL);
            this.SetParamSimple(map, prefix + "MD5", this.MD5);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "WriteBackCosPath", this.WriteBackCosPath);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "CallbackURL", this.CallbackURL);
            this.SetParamSimple(map, prefix + "MediaType", this.MediaType);
        }
    }
}

