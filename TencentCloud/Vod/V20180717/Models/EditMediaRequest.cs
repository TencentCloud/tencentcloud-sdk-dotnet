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

    public class EditMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// 输入视频的类型，可以取的值为  File，Stream 两种。
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// 输入的视频文件信息，当 InputType 为 File 时必填。
        /// </summary>
        [JsonProperty("FileInfos")]
        public EditMediaFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// 输入的流信息，当 InputType 为 Stream 时必填。
        /// </summary>
        [JsonProperty("StreamInfos")]
        public EditMediaStreamInfo[] StreamInfos{ get; set; }

        /// <summary>
        /// [任务流模板](/document/product/266/11700#.E4.BB.BB.E5.8A.A1.E6.B5.81.E6.A8.A1.E6.9D.BF)名字，如果要对生成的新视频执行任务流时填写。
        /// </summary>
        [JsonProperty("ProcedureName")]
        public string ProcedureName{ get; set; }

        /// <summary>
        /// 点播[子应用](/document/product/266/14574) ID。如果要访问子应用中的资源，则将该字段填写为子应用 ID；否则无需填写该字段。
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArrayObj(map, prefix + "StreamInfos.", this.StreamInfos);
            this.SetParamSimple(map, prefix + "ProcedureName", this.ProcedureName);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

