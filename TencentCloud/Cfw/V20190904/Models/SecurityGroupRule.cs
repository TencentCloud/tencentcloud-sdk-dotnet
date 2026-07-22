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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityGroupRule : AbstractModel
    {
        
        /// <summary>
        /// 规则用途或使用场景的描述，不能为空，最多 100 个 Unicode 字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 访问目的内容，非空且最多 512 字节，格式由 DestType 决定：net 使用 IPv4 IP/CIDR，且不接受裸地址 0.0.0.0，表示全部 IPv4 地址时使用 0.0.0.0/0；template 使用可用的地址模板 ID；instance 使用属于当前账号的资产实例 ID；resourcegroup 使用当前账号的资产分组 ID；tag 使用当前账号已存在的资源标签 JSON 字符串，例如 {\"Key\":\"标签键\",\"Value\":\"标签值\"}；region 使用支持的地域标识；dnsparse 使用合法域名。DestType=dnsparse 时服务端将内容转换为小写，并检查域名格式和域名解析配额。
        /// </summary>
        [JsonProperty("DestContent")]
        public string DestContent{ get; set; }

        /// <summary>
        /// 访问目的类型，不区分大小写，可传 net、template、instance、resourcegroup、tag、region 或 dnsparse。instance 的具体资产类型由 DestContent 的实例 ID 前缀识别；template、instance、resourcegroup、tag、region 对应的内容必须对当前账号有效。
        /// </summary>
        [JsonProperty("DestType")]
        public string DestType{ get; set; }

        /// <summary>
        /// 规则顺序的十进制整数字符串；-1 转换为 uint32 最大值。新增时 Type=0 或 1 会按 Data 数组顺序重新计算最终 Sequence；Type=2 使用首条规则的 OrderIndex 作为插入位置，超过当前最大 Sequence 时按末尾新增处理。修改规则内容时 -1 会被拒绝，超过当前最大 Sequence 的值归一化为当前最大 Sequence。
        /// </summary>
        [JsonProperty("OrderIndex")]
        public string OrderIndex{ get; set; }

        /// <summary>
        /// 访问控制动作，不区分大小写。accept 表示放行，drop 表示拒绝，log 表示仅记录；isolateinaccept、isolateoutaccept 分别按放行动作写入并标记入向或出向隔离来源，isolateindrop、isolateoutdrop 分别按拒绝动作写入并标记入向或出向隔离来源。
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// 访问源内容，非空且最多 512 字节，格式由 SourceType 决定：net 使用 IPv4 IP/CIDR，且不接受裸地址 0.0.0.0，表示全部 IPv4 地址时使用 0.0.0.0/0；template 使用可用的地址模板 ID；instance 使用属于当前账号的资产实例 ID；resourcegroup 使用当前账号的资产分组 ID；tag 使用当前账号已存在的资源标签 JSON 字符串，例如 {\"Key\":\"标签键\",\"Value\":\"标签值\"}；region 使用支持的地域标识；dnsparse 使用字符串内容。SourceType=dnsparse 时，服务端接受该类型，但不执行目的域名的小写归一化、域名格式校验或域名解析配额检查。
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// 访问源类型，不区分大小写，可传 net、template、instance、resourcegroup、tag、region 或 dnsparse。instance 的具体资产类型由 SourceContent 的实例 ID 前缀识别；template、instance、resourcegroup、tag、region 对应的内容必须对当前账号有效。dnsparse 作为访问源时不执行目的域名的小写归一化、域名格式校验或域名解析配额检查。
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 规则状态字符串，不区分大小写；true 表示启用，false 表示禁用，省略或空字符串在结构转换时按 true 解析。普通新增最终使用账号的新增规则默认状态；batch_import 和 batch_import_cover 新增保留 Data.Enable 的解析结果；修改规则内容时保留原规则状态，因此 Data.Enable 不改变该修改的启停结果。
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// 规则数据库数值 ID。普通新增由服务端生成；新增请求仅在 IsUseId=1 时采用 Data.Id。修改规则内容时 Data.Id 不改变目标规则 ID，服务端保留由外层 RuleUuid 定位的原 ID。当前 Schema 将本字段声明为字符串，而后端请求结构按 JSON 整数解析；传入字符串会导致请求解析失败。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 访问控制端口字符串，最多 200 字节。未使用服务模板时不能为空，可传 1..65535 的单端口、以斜杠连接且两端分别位于 1..65535 的范围、最多 15 个逗号分隔项，或以 -1/-1 表示全部端口；Protocol 为 ANY 或 ICMP 时必须为 -1/-1。使用服务模板时 Protocol、Port 可同时省略或留空；若任一字段非空，则只接受 Protocol=ANY 且 Port=-1/-1。
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// IPv4 企业安全组协议，区分大小写。未使用服务模板时必须填写 ANY、TCP、UDP 或 ICMP；ANY 和 ICMP 仅支持 Port=-1/-1。使用服务模板时 Protocol、Port 可同时省略或留空；若填写则只接受 Protocol=ANY 且 Port=-1/-1。ICMPv6 由独立的 IPv6 企业安全组接口处理。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 规则生效范围，使用大写 SG、LH 或无空格的逗号分隔组合；SG 表示安全组，LH 表示轻量应用服务器。新增时省略默认补为 SG；修改规则内容时省略表示保留原范围。范围包含 LH 时，SourceType、DestType 均不能为 template，且不能使用 ServiceTemplateId。
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// 协议端口模板 ID，最多 50 字节，必须属于当前账号或为当前账号可用的公共模板。非空时 Protocol、Port 可同时省略或留空；若任一字段非空，则只接受 Protocol=ANY 且 Port=-1/-1。Scope 包含 LH 时不能使用服务模板。
        /// </summary>
        [JsonProperty("ServiceTemplateId")]
        public string ServiceTemplateId{ get; set; }

        /// <summary>
        /// Schema 中声明的规则内部 UUID 字段。当前新增和修改请求结构绑定的 JSON 键名为 UuId 而不是 Uid，因此传入本字段不会参与这两个接口的内部 UUID 生成或复用。
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DestContent", this.DestContent);
            this.SetParamSimple(map, prefix + "DestType", this.DestType);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "ServiceTemplateId", this.ServiceTemplateId);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
        }
    }
}

