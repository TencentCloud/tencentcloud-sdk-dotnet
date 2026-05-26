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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyObjectRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>修改对象标识</p>
        /// </summary>
        [JsonProperty("ObjectId")]
        public string ObjectId{ get; set; }

        /// <summary>
        /// <p>改动作类型:Status修改开关，InstanceId绑定实例, Proxy设置代理状态</p>
        /// </summary>
        [JsonProperty("OpType")]
        public string OpType{ get; set; }

        /// <summary>
        /// <p>新的Waf开关状态，如果和已有状态相同认为修改成功。状态可以为0或1</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>新的实例ID，如果和已绑定的实例相同认为修改成功</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>是否开启代理，0:不开启,1:以XFF的第一个IP地址作为客户端IP,2:以remote_addr作为客户端IP,3:从指定的头部字段获取客户端IP，字段通过IpHeaders字段给出(OpType为Status或Proxy时，该值有效)</p>
        /// </summary>
        [JsonProperty("Proxy")]
        public ulong? Proxy{ get; set; }

        /// <summary>
        /// <p>IsCdn=3时，需要填此参数，表示自定义header(OpType为Status或Proxy时，该值有效)</p>
        /// </summary>
        [JsonProperty("IpHeaders")]
        public string[] IpHeaders{ get; set; }

        /// <summary>
        /// <p>对象所属集团成员appid</p>
        /// </summary>
        [JsonProperty("MemberAppId")]
        public ulong? MemberAppId{ get; set; }

        /// <summary>
        /// <p>对象所属集团成员uin</p>
        /// </summary>
        [JsonProperty("MemberUin")]
        public string MemberUin{ get; set; }

        /// <summary>
        /// <p>标签信息</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "OpType", this.OpType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Proxy", this.Proxy);
            this.SetParamArraySimple(map, prefix + "IpHeaders.", this.IpHeaders);
            this.SetParamSimple(map, prefix + "MemberAppId", this.MemberAppId);
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

