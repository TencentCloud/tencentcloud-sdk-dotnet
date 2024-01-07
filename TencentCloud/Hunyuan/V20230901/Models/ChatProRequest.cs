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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChatProRequest : AbstractModel
    {
        
        /// <summary>
        /// 聊天上下文信息。
        /// 说明：
        /// 1.长度最多为40, 按对话时间从旧到新在数组中排列。
        /// 2.Message的Role当前可选值：system、user、assistant，其中，system角色是可选的，如果存在，必须位于列表的最开始。user和assistant需要交替出现(一问一答)，最后一个为user提问, 且Content不能为空。
        /// 3.Messages中Content总长度不超过16000 token，超过则会截断最前面的内容，只保留尾部内容。建议不超过4000 token。
        /// </summary>
        [JsonProperty("Messages")]
        public Message[] Messages{ get; set; }

        /// <summary>
        /// 说明：
        /// 1.影响输出文本的多样性，取值越大，生成文本的多样性越强。
        /// 2.默认1.0，取值区间为[0.0, 1.0]。
        /// 3.非必要不建议使用, 不合理的取值会影响效果。
        /// </summary>
        [JsonProperty("TopP")]
        public float? TopP{ get; set; }

        /// <summary>
        /// 说明：
        /// 1.较高的数值会使输出更加随机，而较低的数值会使其更加集中和确定。
        /// 2.默认1.0，取值区间为[0.0，2.0]。
        /// 3.非必要不建议使用,不合理的取值会影响效果。
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Messages.", this.Messages);
            this.SetParamSimple(map, prefix + "TopP", this.TopP);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
        }
    }
}

