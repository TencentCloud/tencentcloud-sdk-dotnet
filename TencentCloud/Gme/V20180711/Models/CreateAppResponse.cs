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

    public class CreateAppResponse : AbstractModel
    {
        
        /// <summary>
        /// 应用ID，由后台自动生成。
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// 应用名称，透传输入参数的AppName
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 项目ID，透传输入的ProjectId
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 应用密钥，GME SDK初始化时使用
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// 服务创建时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "RealtimeSpeechConf.", this.RealtimeSpeechConf);
            this.SetParamObj(map, prefix + "VoiceMessageConf.", this.VoiceMessageConf);
            this.SetParamObj(map, prefix + "VoiceFilterConf.", this.VoiceFilterConf);
        }
    }
}

