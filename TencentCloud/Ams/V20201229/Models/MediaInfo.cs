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

namespace TencentCloud.Ams.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaInfo : AbstractModel
    {
        
        /// <summary>
        /// 该字段用于返回传入的媒体文件的编码格式，如wav、mp3、aac、flac、amr、3gp、 m4a、wma、ogg、ape等。
        /// </summary>
        [JsonProperty("Codecs")]
        public string Codecs{ get; set; }

        /// <summary>
        /// 该字段用于返回对传入的流媒体文件进行分片的片段时长，单位为毫秒。**默认值为15秒**，支持用户自定义配置。
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// *内测中，敬请期待*
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// *内测中，敬请期待*
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// *内测中，敬请期待*
        /// </summary>
        [JsonProperty("Thumbnail")]
        public string Thumbnail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codecs", this.Codecs);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Thumbnail", this.Thumbnail);
        }
    }
}

