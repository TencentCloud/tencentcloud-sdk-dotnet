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

    public class VpcRuleItem : AbstractModel
    {
        
        /// <summary>
        /// 规则描述，不超过 100 个字符。新增时按请求值保存；修改时完整替换，不继承旧值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 访问目的内容，由 DestType 决定格式和校验。net/ip 接受合法 IP 或 CIDR 的逗号分隔列表，最多 10 项；domain 接受合法域名的逗号分隔列表或单独的 *，最多 10 项，通配域名最多 5 级，段内通配域名还要求引擎支持对应能力；template 接受当前租户的地址模板标识并归一化为模板 UUID，IP 地址模板必须与 IpVersion 一致，域名地址模板按域名目的校验；dnsparse 接受单个非 IP 域名或当前租户的域名模板，可使用符合级数限制的 *. 前缀泛域名，但不接受单独的 * 或段内通配；domainiptwoverify 接受单个非 IP 精确域名或不含任何通配符的当前租户域名模板；instance 和 tag 必须在当前租户存在，其中 instance 必须具有 IpVersion 对应的私网地址；group 接受资源组标识。归一化后的目的内容超过 1023 字节时请求失败。
        /// </summary>
        [JsonProperty("DestContent")]
        public string DestContent{ get; set; }

        /// <summary>
        /// 访问目的类型，不区分大小写。net、ip 均表示 IP/CIDR，template 表示地址模板，instance 表示资产实例，group 表示资产分组，tag 表示资源标签，domain 表示 FQDN 匹配，dnsparse 表示宽松匹配：Host/SNI 与域名匹配，或目的 IP 属于该域名当前 DNS 解析结果，满足任一条件即命中；domainiptwoverify 表示严格匹配：上述两个条件必须同时满足。url 虽可被通用类型映射识别，但 VPC 目的内容不支持。地址模板和部分域名模式要求当前 VPC 防火墙引擎支持对应能力；类型及模板实际类型共同决定 DestContent 和 Protocol 的校验。
        /// </summary>
        [JsonProperty("DestType")]
        public string DestType{ get; set; }

        /// <summary>
        /// 规则生效的 VPC 边范围，不区分大小写。ALL 表示全部 VPC 边，cfws- 前缀表示指定 VPC 边；其它格式无效。ALL 要求当前环境支持 VPC 全局规则。
        /// </summary>
        [JsonProperty("EdgeId")]
        public string EdgeId{ get; set; }

        /// <summary>
        /// 规则状态，不区分大小写：true 表示启用，false 表示禁用。省略或为空时使用账号默认状态；没有可用默认值时启用。
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// 规则在相同 IpVersion 下的顺序。-1 表示追加到末尾；正序号表示在对应位置插入并顺延后续规则。0、其它负数及超范围值不应使用。批量新增按 Rules 顺序依次处理。
        /// </summary>
        [JsonProperty("OrderIndex")]
        public long? OrderIndex{ get; set; }

        /// <summary>
        /// 访问端口。除 ICMP 和 ICMPV6 外，支持逗号分隔的正整数单端口或“起始/结束”范围，且起始值不大于结束值；-1/-1 表示全部端口。ICMP 和 ICMPV6 忽略该字段；FTP 仅支持单个正整数端口。
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 协议名称，不区分大小写并归一化。ANY 表示不限定协议，不表示省略 Protocol。IP、instance、tag、group 及 IP 地址模板目的支持 TCP、UDP、ICMP、ICMPV6、ANY 和 FTP，其中 FTP 只接受单端口；domain 及域名地址模板目的支持 ANY、HTTP、HTTPS、HTTP/HTTPS、TLS/SSL、SMTP、SMTPS、SMTP/SMTPS 和 DNS，不支持 FTP，domain、tls、ssl 归一化为 TLS/SSL；dnsparse 和 domainiptwoverify 仅支持 TCP 或 UDP。template 按查询到的实际模板类型应用上述限制；填写 ParamTemplateId 时，组内每个协议端口项还会应用相同的目的类型限制。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 流量通过云防火墙时的处理方式，不区分大小写。accept 表示放行，drop 表示拒绝，log 表示观察；isolateinaccept 表示放行访问隔离资产的白名单流量，isolateindrop 表示阻断访问隔离资产的其它流量，isolateoutaccept 表示放行隔离资产访问白名单目标，isolateoutdrop 表示阻断隔离资产访问其它目标；其它值返回参数错误。
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// 访问源内容，格式由 SourceType 决定：net/ip 使用最多 10 个逗号分隔的 IP 或 CIDR；template 使用当前账号且匹配 IpVersion 的 IP 地址模板 ID，不支持域名模板；instance、tag 必须属于当前账号，instance 须有对应 IpVersion 的私网地址；group 使用资源组 ID。
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// 访问源类型，不区分大小写：net、ip 均表示 IP/CIDR，template 表示地址模板，instance 表示资产实例，tag 表示资源标签，group 表示资产分组。类型及模板实际类型决定 SourceContent 的格式；template 要求当前环境支持地址模板。
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 规则关联的 beta 任务详情。请求中的该字段不参与新增或修改规则构造，主要用于查询返回。
        /// </summary>
        [JsonProperty("BetaList")]
        public BetaInfoByACL[] BetaList{ get; set; }

        /// <summary>
        /// 规则创建时间。请求中的该字段不参与新增或修改规则构造，主要用于查询返回。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 规则删除标记，1 表示已删除，0 表示未删除。请求中的该字段不参与新增或修改规则构造，主要用于查询返回。
        /// </summary>
        [JsonProperty("Deleted")]
        public long? Deleted{ get; set; }

        /// <summary>
        /// 目的实际类型提示，例如区分 IP 地址模板和域名地址模板；新增和修改请求中忽略。
        /// </summary>
        [JsonProperty("DestValueType")]
        public string DestValueType{ get; set; }

        /// <summary>
        /// 规则命中次数。请求中的该字段不参与新增或修改规则构造，主要用于查询返回。
        /// </summary>
        [JsonProperty("DetectedTimes")]
        public long? DetectedTimes{ get; set; }

        /// <summary>
        /// EdgeId 对应的 VPC 边名称。请求中的该字段不参与新增或修改规则构造，主要用于查询返回和操作记录展示。
        /// </summary>
        [JsonProperty("EdgeName")]
        public string EdgeName{ get; set; }

        /// <summary>
        /// 规则生效的防火墙组或 CCN 范围，不区分大小写。支持 ALL、cfwg- 前缀和 ccn- 前缀；省略、为空或格式无效时按 ALL 处理。
        /// </summary>
        [JsonProperty("FwGroupId")]
        public string FwGroupId{ get; set; }

        /// <summary>
        /// 防火墙组或 CCN 名称。请求中的该字段不参与新增或修改规则构造，主要用于查询返回和操作记录展示。
        /// </summary>
        [JsonProperty("FwGroupName")]
        public string FwGroupName{ get; set; }

        /// <summary>
        /// 覆盖导入规则标识。仅 batch_import_cover 接受正整数值；其它新增方式和修改请求中忽略。
        /// </summary>
        [JsonProperty("InternalUuid")]
        public long? InternalUuid{ get; set; }

        /// <summary>
        /// 查询结果中的规则有效性标记，0 表示有效，1 表示无效。请求中的该字段不参与新增或修改规则构造。
        /// </summary>
        [JsonProperty("Invalid")]
        public long? Invalid{ get; set; }

        /// <summary>
        /// IP 版本：0 表示 IPv4，1 表示 IPv6；省略或传入其它整数时按 IPv4 处理。instance 和 IP 地址模板须匹配该版本；直接填写的 net IP/CIDR 也应使用相同版本。
        /// </summary>
        [JsonProperty("IpVersion")]
        public long? IpVersion{ get; set; }

        /// <summary>
        /// 端口协议组 ID。省略或为空时使用 Protocol 和 Port；非空时必须是当前账号可用的端口协议组，组内协议端口须满足目的类型限制。Protocol 和非 ICMP/ICMPV6 的 Port 仍须使用有效格式。
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public string ParamTemplateId{ get; set; }

        /// <summary>
        /// 端口协议组名称。请求中的该字段不参与新增或修改规则构造，主要用于查询返回。
        /// </summary>
        [JsonProperty("ParamTemplateName")]
        public string ParamTemplateName{ get; set; }

        /// <summary>
        /// 规则位置展示值：1 表示最前，2 表示中间，3 表示最后。新增和修改请求中忽略；仅位置为 2 的规则可修改。
        /// </summary>
        [JsonProperty("RulePartition")]
        public long? RulePartition{ get; set; }

        /// <summary>
        /// 访问源名称。请求中的该字段不参与新增或修改规则构造，主要用于查询返回和操作记录展示。
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// 访问目的名称。请求中的该字段不参与新增或修改规则构造，主要用于查询返回和操作记录展示。
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// 规则最近更新时间。请求中的该字段不参与新增或修改规则构造，主要用于查询返回。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 规则 ID。修改时必须提供当前账号已有且可修改的正整数 Uuid，并完整替换该规则。普通新增、insert_rule 和 batch_import 忽略该字段；batch_import_cover 可使用正整数 ID，非正数值由系统分配。
        /// </summary>
        [JsonProperty("Uuid")]
        public long? Uuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DestContent", this.DestContent);
            this.SetParamSimple(map, prefix + "DestType", this.DestType);
            this.SetParamSimple(map, prefix + "EdgeId", this.EdgeId);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamArrayObj(map, prefix + "BetaList.", this.BetaList);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Deleted", this.Deleted);
            this.SetParamSimple(map, prefix + "DestValueType", this.DestValueType);
            this.SetParamSimple(map, prefix + "DetectedTimes", this.DetectedTimes);
            this.SetParamSimple(map, prefix + "EdgeName", this.EdgeName);
            this.SetParamSimple(map, prefix + "FwGroupId", this.FwGroupId);
            this.SetParamSimple(map, prefix + "FwGroupName", this.FwGroupName);
            this.SetParamSimple(map, prefix + "InternalUuid", this.InternalUuid);
            this.SetParamSimple(map, prefix + "Invalid", this.Invalid);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamSimple(map, prefix + "ParamTemplateName", this.ParamTemplateName);
            this.SetParamSimple(map, prefix + "RulePartition", this.RulePartition);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
        }
    }
}

