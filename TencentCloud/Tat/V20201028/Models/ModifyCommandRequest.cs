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

    public class ModifyCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>命令ID。可通过 <a href="https://cloud.tencent.com/document/api/1340/52681">DescribeCommands(查询命令详情)</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

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
        /// <p>命令脚本内容。 需 Base64 编码后传入。</p><p>当 EnableParameter = true 时，支持两种动态参数占位符：</p><ul><li>普通参数 {{key}}：例如脚本 <code>echo {{word}}</code> 配合参数 <code>{&quot;word&quot;: &quot;hello&quot;}</code>，实际执行 <code>echo hello</code>，执行记录显示 <code>{&quot;word&quot;: &quot;hello&quot;}</code>。</li><li>隐藏参数 {{tat-hidden:key}}：用于敏感信息脱敏。例如脚本 <code>echo {{tat-hidden:word}}</code> 配合参数 <code>{&quot;word&quot;: &quot;hello&quot;}</code>（传参 Key 不带前缀），实际执行 <code>echo hello</code>，记录显示 <code>{&quot;word&quot;: &quot;******&quot;}</code>。</li></ul><p>参数格式：Base64 编码字符串</p><p>入参限制：Base64 编码后的字符串长度不能超过 64KB</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>命令类型，目前支持取值：SHELL、POWERSHELL、BAT。</p>
        /// </summary>
        [JsonProperty("CommandType")]
        public string CommandType{ get; set; }

        /// <summary>
        /// <p>命令执行路径。</p>
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public string WorkingDirectory{ get; set; }

        /// <summary>
        /// <p>命令超时时间。</p><p>取值范围：[1, 86400]</p><p>单位：秒</p><p>默认值：60</p><p>指定 OutputCOSBucketUrl 参数时，超时时间将包含命令输出上传 COS 的耗时</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>启用自定义参数功能时，自定义参数的默认取值。字段类型为json encoded string。如：{&quot;varA&quot;: &quot;222&quot;}。<br>参数不支持同时指定 <code>DefaultParameters</code> 和 <code>DefaultParameterConfs</code> 。<br>采取整体全覆盖式修改，即修改时必须提供所有新默认值。<br>仅在命令的 EnableParameter 为 true 时，才允许修改此参数。可通过 <a href="https://cloud.tencent.com/document/api/1340/52681">DescribeCommands(查询命令详情)</a> 接口获取命令的 EnableParameter 设置。<br>key为自定义参数名称，value为该参数的默认取值。kv均为字符串型。<br>自定义参数最多20个。<br>自定义参数名称需符合以下规范：字符数目上限64，可选范围【a-zA-Z0-9-_】。</p>
        /// </summary>
        [JsonProperty("DefaultParameters")]
        public string DefaultParameters{ get; set; }

        /// <summary>
        /// <p>自定义参数数组。如果 InvokeCommand 时未提供参数取值，将使用这里的默认值进行替换。<br>参数不支持同时指定 <code>DefaultParameters</code> 和 <code>DefaultParameterConfs</code> 。<br>仅在命令的 EnableParameter 为 true 时，才允许修改此参数。可通过 <a href="https://cloud.tencent.com/document/api/1340/52681">DescribeCommands(查询命令详情)</a> 接口获取命令的 EnableParameter 设置。<br>自定义参数最多20个。</p>
        /// </summary>
        [JsonProperty("DefaultParameterConfs")]
        public DefaultParameterConf[] DefaultParameterConfs{ get; set; }

        /// <summary>
        /// <p>在 CVM 或 Lighthouse 实例中执行命令的用户名称。<br>使用最小权限执行命令是权限管理的最佳实践，建议您以普通用户身份执行云助手命令。</p>
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
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamSimple(map, prefix + "CommandName", this.CommandName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "CommandType", this.CommandType);
            this.SetParamSimple(map, prefix + "WorkingDirectory", this.WorkingDirectory);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "DefaultParameters", this.DefaultParameters);
            this.SetParamArrayObj(map, prefix + "DefaultParameterConfs.", this.DefaultParameterConfs);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "OutputCOSBucketUrl", this.OutputCOSBucketUrl);
            this.SetParamSimple(map, prefix + "OutputCOSKeyPrefix", this.OutputCOSKeyPrefix);
        }
    }
}

