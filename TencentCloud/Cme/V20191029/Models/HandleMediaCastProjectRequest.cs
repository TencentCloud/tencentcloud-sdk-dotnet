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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HandleMediaCastProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台 Id，指定访问的平台。关于平台概念，请参见文档 [平台](https://cloud.tencent.com/document/product/1156/43767)。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 媒体转推项目 Id 。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 请参考 [操作类型](#Operation)。
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 输入源信息。具体操作方式详见 [操作类型](#Operation) 及下文示例。
        /// 当 Operation 为 AddSource、DeleteSource、SwitchSource 时必填。
        /// </summary>
        [JsonProperty("SourceInfos")]
        public MediaCastSourceInfo[] SourceInfos{ get; set; }

        /// <summary>
        /// 输出源信息。具体操作方式详见 [操作类型](#Operation) 及下文示例。
        /// 当 Operation 为 AddDestination、DeleteDestination、EnableDestination、DisableDestination、ModifyDestination 时必填。
        /// </summary>
        [JsonProperty("DestinationInfos")]
        public MediaCastDestinationInfo[] DestinationInfos{ get; set; }

        /// <summary>
        /// 输出媒体配置。具体操作方式详见 [操作类型](#Operation) 及下文示例。
        /// 当 Operation 为 ModfiyOutputSetting 时必填。
        /// </summary>
        [JsonProperty("OutputMediaSetting")]
        public MediaCastOutputMediaSetting OutputMediaSetting{ get; set; }

        /// <summary>
        /// 播放控制参数。具体操作方式详见 [操作类型](#Operation) 及下文示例。
        /// 当 Operation 为 ModifyPlaySetting 时必填。
        /// </summary>
        [JsonProperty("PlaySetting")]
        public MediaCastPlaySetting PlaySetting{ get; set; }

        /// <summary>
        /// 新添加的输入源位于输入源列表的位置，从0开始。默认加在输入源列表的后面。具体操作方式详见 [操作类型](#Operation) 及下文示例。
        /// 当 Operation 为 AddSource 时必填。
        /// </summary>
        [JsonProperty("Position")]
        public long? Position{ get; set; }

        /// <summary>
        /// 操作者。如不填，默认为 `cmeid_system`，表示平台管理员操作，可以操作所有媒体转推项目。如果指定操作者，则操作者必须为项目所有者。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamArrayObj(map, prefix + "SourceInfos.", this.SourceInfos);
            this.SetParamArrayObj(map, prefix + "DestinationInfos.", this.DestinationInfos);
            this.SetParamObj(map, prefix + "OutputMediaSetting.", this.OutputMediaSetting);
            this.SetParamObj(map, prefix + "PlaySetting.", this.PlaySetting);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

