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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPullStreamConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>配置 ID。<br>获取来源：</p><ol><li>创建拉流配置接口CreatePullStreamConfig返回的配置 ID。</li><li>通过查询接口DescribePullStreamConfigs获取配置 ID。</li></ol>
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// <p>源 URL，用于拉流的地址。目前可支持直播流及点播文件。<br>注意：</p><ol><li>多个点播 URL 之间使用空格拼接。</li><li>目前上限支持10个 URL。</li><li>支持拉流文件格式：FLV，RTMP，HLS，MP4。</li><li>使用标准三层样式，如：http://test.com/live/stream.flv。</li></ol>
        /// </summary>
        [JsonProperty("FromUrl")]
        public string FromUrl{ get; set; }

        /// <summary>
        /// <p>目的 URL，用于推流的地址，目前限制该目标地址为腾讯域名。</p><ol><li>仅支持 RTMP 协议。</li><li>使用标准三层样式，如：http://test.com/live/stream.flv。</li></ol>
        /// </summary>
        [JsonProperty("ToUrl")]
        public string ToUrl{ get; set; }

        /// <summary>
        /// <p>区域 ID：<br>1-深圳。<br>2-上海。<br>3-天津。<br>4-中国香港。<br>如有改动，需同时传入IspId。</p>
        /// </summary>
        [JsonProperty("AreaId")]
        public long? AreaId{ get; set; }

        /// <summary>
        /// <p>运营商 ID，<br>1：电信。<br>2：移动。<br>3：联通。<br>4：其他。<br>AreaId为4的时候，IspId只能为其他。如有改动，需同时传入AreaId。</p>
        /// </summary>
        [JsonProperty("IspId")]
        public long? IspId{ get; set; }

        /// <summary>
        /// <p>开始时间。<br>使用UTC格式时间，<br>例如：2019-01-08T10:00:00Z。<br>注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 <a href="https://cloud.tencent.com/document/product/266/11732#I">ISO 日期格式说明</a>。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间，注意：</p><ol><li>结束时间必须大于开始时间；</li><li>结束时间和开始时间必须大于当前时间；</li><li>结束时间 和 开始时间 间隔必须小于七天。</li></ol><p>使用UTC格式时间，<br>例如：2019-01-08T10:00:00Z。<br>注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 <a href="https://cloud.tencent.com/document/product/266/11732#I">ISO 日期格式说明</a>。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "FromUrl", this.FromUrl);
            this.SetParamSimple(map, prefix + "ToUrl", this.ToUrl);
            this.SetParamSimple(map, prefix + "AreaId", this.AreaId);
            this.SetParamSimple(map, prefix + "IspId", this.IspId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

