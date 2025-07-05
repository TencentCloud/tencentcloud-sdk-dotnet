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
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

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
        /// 编辑模板 ID，取值有 10，20，不填代表使用 10 模板。
        /// <li>10：拼接时，以分辨率最高的输入为基准；</li>
        /// <li>20：拼接时，以码率最高的输入为基准。</li>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// [任务流](https://cloud.tencent.com/document/product/266/33475#.E4.BB.BB.E5.8A.A1.E6.B5.81)名称，如果要对生成的新视频执行任务流时填写。
        /// </summary>
        [JsonProperty("ProcedureName")]
        public string ProcedureName{ get; set; }

        /// <summary>
        /// 编辑后生成的文件配置。
        /// </summary>
        [JsonProperty("OutputConfig")]
        public EditMediaOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// 标识来源上下文，用于透传用户请求信息，在EditMediaComplete回调和任务流状态变更回调将返回该字段值，最长 1000个字符。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// 任务的优先级，数值越大优先级越高，取值范围是 -10 到 10，不填代表 0。
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// 用于任务去重的识别码，如果三天内曾有过相同的识别码的请求，则本次的请求会返回错误。最长 50 个字符，不带或者带空字符串表示不做去重。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 保留字段，特殊用途时使用。
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArrayObj(map, prefix + "StreamInfos.", this.StreamInfos);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "ProcedureName", this.ProcedureName);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

