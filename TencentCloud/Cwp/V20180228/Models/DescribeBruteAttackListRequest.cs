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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBruteAttackListRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要返回的数量，最大值为100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li>IpOrAlias - String - 是否必填：否 - 主机ip或别名筛选</li>
        /// <li>Uuid - String - 是否必填：否 - 主机安全唯一Uuid</li>
        /// <li>Quuid - String - 是否必填：否 - 云服务器uuid</li>
        /// <li>Status - String - 是否必填：否 - 状态筛选：失败：FAILED 成功：SUCCESS</li>
        /// <li>UserName - String - 是否必填：否 - UserName筛选</li>
        /// <li>SrcIp - String - 是否必填：否 - 来源ip筛选</li>
        /// <li>CreateBeginTime - String - 是否必填：否 - 首次攻击时间筛选，开始时间</li>
        /// <li>CreateEndTime - String - 是否必填：否 - 首次攻击时间筛选，结束时间</li>
        /// <li>ModifyBeginTime - String - 是否必填：否 - 最近攻击时间筛选，开始时间</li>
        /// <li>ModifyEndTime - String - 是否必填：否 - 最近攻击时间筛选，结束时间</li>
        /// <li>Banned - String - 是否必填：否 - 阻断状态筛选，多个用","分割：0-未阻断（全局ZK开关关闭），82-未阻断(非专业版)，83-未阻断(已加白名单)，1-阻断成功(已完成)，2-未阻断-程序异常，3-未阻断-内网攻击暂不支持阻断，4-未阻断-安平暂不支持阻断，10-阻断成功(生效中)</li>
        /// <li>DataFrom - Int - 命中规则：0-登录规则，1-情报规则</li>
        /// <li>EventType - String - 是否必填：否 - 破解状态筛选：200-破解失败(密码错误),300-破解成功,400-破解失败(账号不存在)</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序方式：根据请求次数排序：asc-升序/desc-降序
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段：CreateTime-首次攻击时间
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

