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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLiveRecordTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// HLS配置参数，和MP4Configure需要二选一必填。
        /// </summary>
        [JsonProperty("HLSConfigure")]
        public HLSConfigureInfo HLSConfigure{ get; set; }

        /// <summary>
        /// MP4配置参数，和HLSConfigure需要二选一必填。
        /// </summary>
        [JsonProperty("MP4Configure")]
        public MP4ConfigureInfo MP4Configure{ get; set; }

        /// <summary>
        /// 录制模板名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 模板描述信息，长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HLSConfigure.", this.HLSConfigure);
            this.SetParamObj(map, prefix + "MP4Configure.", this.MP4Configure);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

