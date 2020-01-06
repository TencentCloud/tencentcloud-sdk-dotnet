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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAppRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 腾讯云项目ID，默认为0，表示默认项目
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 需要支持的引擎列表，默认全选。
        /// </summary>
        [JsonProperty("EngineList")]
        public string[] EngineList{ get; set; }

        /// <summary>
        /// 服务区域列表，默认全选。
        /// </summary>
        [JsonProperty("RegionList")]
        public string[] RegionList{ get; set; }

        /// <summary>
        /// 实时语音服务配置数据
        /// </summary>
        [JsonProperty("RealtimeSpeechConf")]
        public RealtimeSpeechConf RealtimeSpeechConf{ get; set; }

        /// <summary>
        /// 语音消息及转文本服务配置数据
        /// </summary>
        [JsonProperty("VoiceMessageConf")]
        public VoiceMessageConf VoiceMessageConf{ get; set; }

        /// <summary>
        /// 语音分析服务配置数据
        /// </summary>
        [JsonProperty("VoiceFilterConf")]
        public VoiceFilterConf VoiceFilterConf{ get; set; }

        /// <summary>
        /// 需要添加的标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "EngineList.", this.EngineList);
            this.SetParamArraySimple(map, prefix + "RegionList.", this.RegionList);
            this.SetParamObj(map, prefix + "RealtimeSpeechConf.", this.RealtimeSpeechConf);
            this.SetParamObj(map, prefix + "VoiceMessageConf.", this.VoiceMessageConf);
            this.SetParamObj(map, prefix + "VoiceFilterConf.", this.VoiceFilterConf);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

