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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyJustInTimeTranscodeTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板名字。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <b>点播[子应用](/document/product/266/14574) ID。如果要访问子应用中的资源，则将该字段填写为子应用 ID；否则无需填写该字段。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public long? SubAppId{ get; set; }

        /// <summary>
        /// 视频参数配置。
        /// </summary>
        [JsonProperty("VideoConfigure")]
        public VideoConfigureInfoForUpdate VideoConfigure{ get; set; }

        /// <summary>
        /// 水印参数配置。
        /// </summary>
        [JsonProperty("WatermarkConfigure")]
        public WatermarkConfigureInfoForUpdate WatermarkConfigure{ get; set; }

        /// <summary>
        /// 模板描述，长度限制256个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "VideoConfigure.", this.VideoConfigure);
            this.SetParamObj(map, prefix + "WatermarkConfigure.", this.WatermarkConfigure);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

