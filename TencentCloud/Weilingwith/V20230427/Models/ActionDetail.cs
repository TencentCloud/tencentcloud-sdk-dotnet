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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActionDetail : AbstractModel
    {
        
        /// <summary>
        /// 动作id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 动作名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 动作类型
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 动作说明
        /// </summary>
        [JsonProperty("ActionDesc")]
        public string ActionDesc{ get; set; }

        /// <summary>
        /// 消息类型，orgin/custom/model
        /// </summary>
        [JsonProperty("MsgType")]
        public string MsgType{ get; set; }

        /// <summary>
        /// 消息内容,有效值为x-json:后的字段
        /// </summary>
        [JsonProperty("MsgContent")]
        public string MsgContent{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [JsonProperty("WID")]
        public string WID{ get; set; }

        /// <summary>
        /// 关联故障列表
        /// </summary>
        [JsonProperty("LinkRuleSet")]
        public LinkRule[] LinkRuleSet{ get; set; }

        /// <summary>
        /// 动作下沉配置,有效值为x-json:后的字段
        /// </summary>
        [JsonProperty("SinkConfig")]
        public string SinkConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ActionDesc", this.ActionDesc);
            this.SetParamSimple(map, prefix + "MsgType", this.MsgType);
            this.SetParamSimple(map, prefix + "MsgContent", this.MsgContent);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "WID", this.WID);
            this.SetParamArrayObj(map, prefix + "LinkRuleSet.", this.LinkRuleSet);
            this.SetParamSimple(map, prefix + "SinkConfig", this.SinkConfig);
        }
    }
}

