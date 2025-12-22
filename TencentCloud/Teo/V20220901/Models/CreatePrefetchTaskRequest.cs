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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePrefetchTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// 若您希望快速提交不同站点下的 Targets Url，可以将其填写为 *，但前提是调用该 API 的账号必须具备主账号下全部站点资源的权限。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 要预热的资源列表，必填。每个元素格式类似如下:
        /// http://www.example.com/example.txt。
        /// 注意：提交任务数受计费套餐配额限制，请查看 [EO计费套餐](https://cloud.tencent.com/document/product/1552/77380)。
        /// </summary>
        [JsonProperty("Targets")]
        public string[] Targets{ get; set; }

        /// <summary>
        /// 预热模式，取值有：
        /// <li>default：默认模式，即预热到中间层；</li>
        /// <li>edge：边缘预热模式，即预热到边缘和中间层。</li>不填写时，默认值为 default。
        /// 注意事项：
        /// 1.预热至边缘产生的边缘层流量，会计入计费流量；
        /// 2.边缘预热默认分配单独的预热额度 1000 条/天，不消费常规预热额度。
        /// 说明：
        /// 该参数为白名单功能，如有需要，请联系腾讯云工程师处理。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 是否对url进行encode，若内容含有非 ASCII 字符集的字符，请开启此开关进行编码转换（编码规则遵循 RFC3986）。
        /// </summary>
        [JsonProperty("EncodeUrl")]
        [System.Obsolete]
        public bool? EncodeUrl{ get; set; }

        /// <summary>
        /// 若需要携带 HTTP 头部信息预热，可入参该参数，否则放空即可。
        /// </summary>
        [JsonProperty("Headers")]
        public Header[] Headers{ get; set; }

        /// <summary>
        /// 媒体分片预热控制，取值有：
        /// <li>on：开启分片预热，预热描述文件，并递归解析描述文件分片进行预热；</li>
        /// <li>off：仅预热提交的描述文件；</li>不填写时，默认值为 off。
        /// 注意事项：
        /// 1. 支持的描述文件为 M3U8，对应分片为 TS；
        /// 2. 要求描述文件能正常请求，并按行业标准描述分片路径；
        /// 3. 递归解析深度不超过 3 层；
        /// 4. 解析获取的分片会正常累加每日预热用量，当用量超出配额时，会静默处理，不再执行预热。
        /// 说明：
        /// 该参数为白名单功能，如有需要，请联系腾讯云工程师处理。
        /// </summary>
        [JsonProperty("PrefetchMediaSegments")]
        public string PrefetchMediaSegments{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "EncodeUrl", this.EncodeUrl);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "PrefetchMediaSegments", this.PrefetchMediaSegments);
        }
    }
}

