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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLiveRecordTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板 ID。
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// 模板名称。
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// FLV 录制参数，开启 FLV 录制时设置。
        /// </summary>
        [JsonProperty("FlvParam")]
        public RecordParam FlvParam{ get; set; }

        /// <summary>
        /// HLS 录制参数，开启 HLS 录制时设置。
        /// </summary>
        [JsonProperty("HlsParam")]
        public RecordParam HlsParam{ get; set; }

        /// <summary>
        /// MP4 录制参数，开启 MP4 录制时设置。
        /// </summary>
        [JsonProperty("Mp4Param")]
        public RecordParam Mp4Param{ get; set; }

        /// <summary>
        /// AAC 录制参数，开启 AAC 录制时设置。
        /// </summary>
        [JsonProperty("AacParam")]
        public RecordParam AacParam{ get; set; }

        /// <summary>
        /// HLS 录制定制参数。
        /// </summary>
        [JsonProperty("HlsSpecialParam")]
        public HlsSpecialParam HlsSpecialParam{ get; set; }

        /// <summary>
        /// MP3 录制参数，开启 MP3 录制时设置。
        /// </summary>
        [JsonProperty("Mp3Param")]
        public RecordParam Mp3Param{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "FlvParam.", this.FlvParam);
            this.SetParamObj(map, prefix + "HlsParam.", this.HlsParam);
            this.SetParamObj(map, prefix + "Mp4Param.", this.Mp4Param);
            this.SetParamObj(map, prefix + "AacParam.", this.AacParam);
            this.SetParamObj(map, prefix + "HlsSpecialParam.", this.HlsSpecialParam);
            this.SetParamObj(map, prefix + "Mp3Param.", this.Mp3Param);
        }
    }
}

