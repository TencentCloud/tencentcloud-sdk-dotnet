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

    public class CreateCommonMixStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// 混流会话（申请混流开始到取消混流结束）标识 ID。
        /// </summary>
        [JsonProperty("MixStreamSessionId")]
        public string MixStreamSessionId{ get; set; }

        /// <summary>
        /// 混流输入流列表。
        /// </summary>
        [JsonProperty("InputStreamList")]
        public CommonMixInputParam[] InputStreamList{ get; set; }

        /// <summary>
        /// 混流输出流参数。
        /// </summary>
        [JsonProperty("OutputParams")]
        public CommonMixOutputParams OutputParams{ get; set; }

        /// <summary>
        /// 输入模板 ID，若设置该参数，将按默认模板布局输出，无需填入自定义位置参数。
        /// 不填默认为0。
        /// 两输入源支持10，20，30，40，50。
        /// 三输入源支持310，390，391。
        /// 四输入源支持410。
        /// 五输入源支持510，590。
        /// 六输入源支持610。
        /// </summary>
        [JsonProperty("MixStreamTemplateId")]
        public long? MixStreamTemplateId{ get; set; }

        /// <summary>
        /// 混流的特殊控制参数。如无特殊需求，无需填写。
        /// </summary>
        [JsonProperty("ControlParams")]
        public CommonMixControlParams ControlParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MixStreamSessionId", this.MixStreamSessionId);
            this.SetParamArrayObj(map, prefix + "InputStreamList.", this.InputStreamList);
            this.SetParamObj(map, prefix + "OutputParams.", this.OutputParams);
            this.SetParamSimple(map, prefix + "MixStreamTemplateId", this.MixStreamTemplateId);
            this.SetParamObj(map, prefix + "ControlParams.", this.ControlParams);
        }
    }
}

