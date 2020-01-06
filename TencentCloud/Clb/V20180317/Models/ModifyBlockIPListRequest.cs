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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBlockIPListRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例ID
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }

        /// <summary>
        /// 操作类型，可取：
        /// <li> add_customized_field（首次设置header，开启黑名单功能）</li>
        /// <li> set_customized_field（修改header）</li>
        /// <li> del_customized_field（删除header）</li>
        /// <li> add_blocked（添加黑名单）</li>
        /// <li> del_blocked（删除黑名单）</li>
        /// <li> flush_blocked（清空黑名单）</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 客户端真实IP存放的header字段名
        /// </summary>
        [JsonProperty("ClientIPField")]
        public string ClientIPField{ get; set; }

        /// <summary>
        /// 封禁IP列表，单次操作数组最大长度支持200000
        /// </summary>
        [JsonProperty("BlockIPList")]
        public string[] BlockIPList{ get; set; }

        /// <summary>
        /// 过期时间，单位秒，默认值3600
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// 添加IP的策略，可取：fifo（如果黑名单容量已满，新加入黑名单的IP采用先进先出策略）
        /// </summary>
        [JsonProperty("AddStrategy")]
        public string AddStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ClientIPField", this.ClientIPField);
            this.SetParamArraySimple(map, prefix + "BlockIPList.", this.BlockIPList);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AddStrategy", this.AddStrategy);
        }
    }
}

