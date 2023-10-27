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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAlertCenterRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 处置时间
        /// 1  1天
        /// 7   7天
        /// -2 永久
        /// </summary>
        [JsonProperty("HandleTime")]
        public long? HandleTime{ get; set; }

        /// <summary>
        /// 处置类型
        /// 当HandleIdList 不为空时：1封禁 2放通  
        /// 当HandleIpList 不为空时：3放通 4封禁
        /// </summary>
        [JsonProperty("HandleType")]
        public long? HandleType{ get; set; }

        /// <summary>
        /// 当前日志方向： 0 出向 1 入向
        /// </summary>
        [JsonProperty("AlertDirection")]
        public long? AlertDirection{ get; set; }

        /// <summary>
        /// 处置方向： 0出向 1入向 0,1出入向 3内网
        /// </summary>
        [JsonProperty("HandleDirection")]
        public string HandleDirection{ get; set; }

        /// <summary>
        /// 处置对象,ID列表，  IdLists和IpList二选一
        /// </summary>
        [JsonProperty("HandleIdList")]
        public string[] HandleIdList{ get; set; }

        /// <summary>
        /// 处置对象,IP列表，  IdLists和IpList二选一
        /// </summary>
        [JsonProperty("HandleIpList")]
        public string[] HandleIpList{ get; set; }

        /// <summary>
        /// 处置描述
        /// </summary>
        [JsonProperty("HandleComment")]
        public string HandleComment{ get; set; }

        /// <summary>
        /// 放通原因:
        /// 0默认 1重复 2误报 3紧急放通
        /// </summary>
        [JsonProperty("IgnoreReason")]
        public long? IgnoreReason{ get; set; }

        /// <summary>
        /// 封禁域名-保留字段
        /// </summary>
        [JsonProperty("BlockDomain")]
        public string BlockDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HandleTime", this.HandleTime);
            this.SetParamSimple(map, prefix + "HandleType", this.HandleType);
            this.SetParamSimple(map, prefix + "AlertDirection", this.AlertDirection);
            this.SetParamSimple(map, prefix + "HandleDirection", this.HandleDirection);
            this.SetParamArraySimple(map, prefix + "HandleIdList.", this.HandleIdList);
            this.SetParamArraySimple(map, prefix + "HandleIpList.", this.HandleIpList);
            this.SetParamSimple(map, prefix + "HandleComment", this.HandleComment);
            this.SetParamSimple(map, prefix + "IgnoreReason", this.IgnoreReason);
            this.SetParamSimple(map, prefix + "BlockDomain", this.BlockDomain);
        }
    }
}

