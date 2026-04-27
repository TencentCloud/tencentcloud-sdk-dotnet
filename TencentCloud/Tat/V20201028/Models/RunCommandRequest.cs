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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>命令脚本内容。 需 Base64 编码后传入。</p><p>当 EnableParameter = true 时，支持两种动态参数占位符：</p><ul><li>普通参数 {{key}}：例如脚本 <code>echo {{word}}</code> 配合参数 <code>{&quot;word&quot;: &quot;hello&quot;}</code>，实际执行 <code>echo hello</code>，执行记录显示 <code>{&quot;word&quot;: &quot;hello&quot;}</code>。</li><li>隐藏参数 {{tat-hidden:key}}：用于敏感信息脱敏。例如脚本 <code>echo {{tat-hidden:word}}</code> 配合参数 <code>{&quot;word&quot;: &quot;hello&quot;}</code>（传参 Key 不带前缀），实际执行 <code>echo hello</code>，记录显示 <code>{&quot;word&quot;: &quot;******&quot;}</code>。</li></ul><p>参数格式：Base64 编码字符串</p><p>入参限制：Base64 编码后的字符串长度不能超过 64KB</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>待执行命令的实例ID列表，上限200。</p><p>可通过对应云产品的查询实例接口获取实例 ID。目前支持实例类型：</p><ul><li>CVM</li><li>Lighthouse</li><li>TAT 托管实例</li></ul>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>命令名称。名称仅支持中文、英文、数字、下划线、分隔符&quot;-&quot;、小数点，最大长度不能超60个字节。</p>
        /// </summary>
        [JsonProperty("CommandName")]
        public string CommandName{ get; set; }

        /// <summary>
        /// <p>命令描述。不超过120字符。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>命令类型，目前支持取值：SHELL、POWERSHELL、BAT。默认：SHELL。</p>
        /// </summary>
        [JsonProperty("CommandType")]
        public string CommandType{ get; set; }

        /// <summary>
        /// <p>命令执行路径，对于 SHELL 命令默认为 /root，对于 POWERSHELL 命令默认为 C:\Program Files\qcloud\tat_agent\workdir。</p>
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public string WorkingDirectory{ get; set; }

        /// <summary>
        /// <p>命令超时时间，默认60秒。取值范围[1, 86400]。</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>是否保存命令，取值范围：</p><li> true：保存</li><li> false：不保存</li>默认为 false。
        /// </summary>
        [JsonProperty("SaveCommand")]
        public bool? SaveCommand{ get; set; }

        /// <summary>
        /// <p>是否启用自定义参数功能。<br>一旦创建，此值不提供修改。<br>取值范围：</p><li> true：启用 </li><li> false：不启用 </li>默认值：false。
        /// </summary>
        [JsonProperty("EnableParameter")]
        public bool? EnableParameter{ get; set; }

        /// <summary>
        /// <p>启用自定义参数功能时，自定义参数的默认取值。字段类型为json encoded string。如：{&quot;varA&quot;: &quot;222&quot;}。<br>key为自定义参数名称，value为该参数的默认取值。kv均为字符串型。<br>仅在命令的 EnableParameter 为 true 时，才允许设置此参数。<br>参数不支持同时指定 <code>DefaultParameters</code> 和 <code>DefaultParameterConfs</code> 。<br>如果 Parameters 未提供，将使用这里的默认值进行替换。<br>自定义参数最多20个。<br>自定义参数名称需符合以下规范：字符数目上限64，可选范围【a-zA-Z0-9-_】。</p>
        /// </summary>
        [JsonProperty("DefaultParameters")]
        public string DefaultParameters{ get; set; }

        /// <summary>
        /// <p>自定义参数数组。 如果 Parameters 未提供，将使用这里的默认值进行替换。 自定义参数最多20个。<br>如果 Parameters 未提供，将使用这里的默认值进行替换。<br>仅在命令的 EnableParameter 为 true 时，才允许设置此参数。<br>参数不支持同时指定 <code>DefaultParameters</code> 和 <code>DefaultParameterConfs</code> 。</p>
        /// </summary>
        [JsonProperty("DefaultParameterConfs")]
        public DefaultParameterConf[] DefaultParameterConfs{ get; set; }

        /// <summary>
        /// <p>Command 的自定义参数。字段类型为json encoded string。如：{&quot;varA&quot;: &quot;222&quot;}。<br>key为自定义参数名称，value为该参数的默认取值。kv均为字符串型。<br>仅在命令的 EnableParameter 为 true 时，才允许设置此参数。<br>如果未提供该参数取值，将使用 DefaultParameters 或 DefaultParameterConfs 进行替换。<br>自定义参数最多20个。<br>自定义参数名称需符合以下规范：字符数目上限64，可选范围【a-zA-Z0-9-_】。</p>
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// <p>如果保存命令，可为命令设置标签。列表长度不超过10。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>在 CVM 或 Lighthouse 实例中执行命令的用户名称。<br>使用最小权限执行命令是权限管理的最佳实践，建议您以普通用户身份执行云助手命令。默认情况下，在 Linux 实例中以 root 用户执行命令；在Windows 实例中以 System 用户执行命令。</p>
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>指定日志上传的cos bucket 地址，必须以https开头，如 https://BucketName-123454321.cos.ap-beijing.myqcloud.com。</p>
        /// </summary>
        [JsonProperty("OutputCOSBucketUrl")]
        public string OutputCOSBucketUrl{ get; set; }

        /// <summary>
        /// <p>指定日志在cos bucket中的目录，目录命名有如下规则：</p><ol><li>可用数字、中英文和可见字符的组合，长度最多为60。</li><li>用 / 分割路径，可快速创建子目录。</li><li>不允许连续 / ；不允许以 / 开头；不允许以..作为文件夹名称。</li></ol>
        /// </summary>
        [JsonProperty("OutputCOSKeyPrefix")]
        public string OutputCOSKeyPrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "CommandName", this.CommandName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CommandType", this.CommandType);
            this.SetParamSimple(map, prefix + "WorkingDirectory", this.WorkingDirectory);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "SaveCommand", this.SaveCommand);
            this.SetParamSimple(map, prefix + "EnableParameter", this.EnableParameter);
            this.SetParamSimple(map, prefix + "DefaultParameters", this.DefaultParameters);
            this.SetParamArrayObj(map, prefix + "DefaultParameterConfs.", this.DefaultParameterConfs);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "OutputCOSBucketUrl", this.OutputCOSBucketUrl);
            this.SetParamSimple(map, prefix + "OutputCOSKeyPrefix", this.OutputCOSKeyPrefix);
        }
    }
}

