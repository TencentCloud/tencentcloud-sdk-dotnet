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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例<a href="https://cloud.tencent.com/document/product/213/2180">计费类型</a>。<br><li>PREPAID：预付费，即包年包月</li><br><li>POSTPAID_BY_HOUR：按小时后付费</li><br><li>CDHPAID：独享子机（基于专用宿主机创建，宿主机部分的资源不收费）</li><br><li>SPOTPAID：竞价付费</li><br><li>CDCPAID：专用集群付费</li><br>默认值：POSTPAID_BY_HOUR。</p>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>预付费模式，即包年包月相关参数设置。通过该参数可以指定包年包月实例的购买时长、是否设置自动续费等属性。若指定实例的付费模式为预付费则该参数必传。</p>
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// <p>实例所在的位置。通过该参数可以指定实例所属可用区，所属项目，所属宿主机（在专用宿主机上创建子机时指定）等属性。<br> <b>注：如果您不指定LaunchTemplate参数，则Placement为必选参数。若同时传递Placement和LaunchTemplate，则默认覆盖LaunchTemplate中对应的Placement的值。</b></p>
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// <p>实例机型。不同实例机型指定了不同的资源规格。<br><br><li>对于付费模式为PREPAID或POSTPAID_BY_HOUR的实例创建，具体取值可通过调用接口<a href="https://cloud.tencent.com/document/api/213/15749">DescribeInstanceTypeConfigs</a>来获得最新的规格表或参见<a href="https://cloud.tencent.com/document/product/213/11518">实例规格</a>描述。若不指定该参数，则系统将根据当前地域的资源售卖情况动态指定默认机型。</li><br><li>对于付费模式为CDHPAID的实例创建，该参数以&quot;CDH_&quot;为前缀，根据CPU和内存配置生成，具体形式为：CDH_XCXG，例如对于创建CPU为1核，内存为1G大小的专用宿主机的实例，该参数应该为CDH_1C1G。</li></p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>指定有效的<a href="https://cloud.tencent.com/document/product/213/4940">镜像</a>ID，格式形如<code>img-xxx</code>。镜像类型分为四种：<br><li>公共镜像</li><li>自定义镜像</li><li>共享镜像</li><li>服务市场镜像</li><br>可通过以下方式获取可用的镜像ID：<br><li><code>公共镜像</code>、<code>自定义镜像</code>、<code>共享镜像</code>的镜像ID可通过登录<a href="https://console.cloud.tencent.com/cvm/image?rid=1&amp;imageType=PUBLIC_IMAGE">控制台</a>查询；<code>服务镜像市场</code>的镜像ID可通过<a href="https://market.cloud.tencent.com/list">云市场</a>查询。</li><li>通过调用接口 <a href="https://cloud.tencent.com/document/api/213/15715">DescribeImages</a> ，传入InstanceType获取当前机型支持的镜像列表，取返回信息中的<code>ImageId</code>字段。</li><br> <b>注：如果您不指定LaunchTemplate参数，则ImageId为必选参数。若同时传递ImageId和LaunchTemplate，则默认覆盖LaunchTemplate中对应的ImageId的值。</b></p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>实例系统盘配置信息。若不指定该参数，则按照系统默认值进行分配。</p>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// <p>实例数据盘配置信息。若不指定该参数，则默认不购买数据盘。支持购买的时候指定21块数据盘，其中最多包含1块LOCAL_BASIC数据盘或者LOCAL_SSD数据盘，最多包含20块CLOUD_BASIC数据盘、CLOUD_PREMIUM数据盘或者CLOUD_SSD数据盘。</p>
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// <p>私有网络相关信息配置。通过该参数可以指定私有网络的ID，子网ID等信息。若在此参数中指定了私有网络IP，即表示每个实例的主网卡IP；同时，InstanceCount参数必须与私有网络IP的个数一致且不能大于20。</p>
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// <p>公网带宽相关信息设置。若不指定该参数，则默认公网带宽为0Mbps。</p>
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// <p>购买实例数量。包年包月实例取值范围：[1，500]，按量计费实例取值范围：[1，500]。默认取值：1。指定购买实例的数量不能超过用户所能购买的剩余配额数量，具体配额相关限制详见<a href="https://cloud.tencent.com/document/product/213/2664">CVM实例购买限制</a>。</p>
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// <p>指定创建实例的最小数量，取值范围为不大于InstanceCount的正整数。<br>指定最小数量时，承诺最少创建MinCount台实例，并尽量创建InstanceCount台实例。<br>库存不足以满足最小数量时，API 会返回库存不足最小数量的错误信息。<br>仅对支持部分发货的账号、区域和计费模式（包年包月、按量计费、竞价实例、按量包销）生效。</p>
        /// </summary>
        [JsonProperty("MinCount")]
        public long? MinCount{ get; set; }

        /// <summary>
        /// <p>实例显示名称。<br><li>不指定实例显示名称则默认显示‘未命名’。</li><li>最多支持128个字符（含模式串）。</li><li>购买多台实例时：</p><ul><li>指定模式串  {R:x}：表示生成数字序列 [x, x+n-1]，其中 n为购买实例的数量。例如：输入 server_{R:3}，购买1台时，实例显示名称为 server_3；购买2台时，实例显示名称分别为 server_3、server_4。</li><li>指定模式串  {R:x,F:y}：y表示固定位数（可选），取值范围为 [0,8]，默认值 0表示不固定位数（等效于 {R:x}）。不足位时自动补零，例如：输入server_{R:3,F:3}，购买2台时，实例显示名称为 server_003、server_004。；若数字位数超过 y（如 {R:99,F:2}），以实际位数为准，例如：app_{R:99,F:2}，购买2台时，实例显示名称为 app_99、app_100。</li><li>模式串需严格遵循 {R:x,F:y}或 {R:x}格式，无效格式（如 {}）视为普通文本。支持多个模式串。</li><li>未指定模式串：实例显示名称添加后缀 1、2...n，其中n表示购买实例的数量，例如 server_购买2台时生成 server_1、server_2。</li></li></ul>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>实例登录设置。通过该参数可以设置实例的登录方式密码、密钥或保持镜像的原始登录设置。默认情况下会随机生成密码，并以站内信方式知会到用户。</p>
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// <p>实例所属安全组。该参数可以通过调用 <a href="https://cloud.tencent.com/document/api/215/15808">DescribeSecurityGroups</a> 的返回值中的 <code>SecurityGroupId</code> 字段来获取。若不指定该参数，则绑定指定项目下的默认安全组，如默认安全组不存在则将自动创建。</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>增强服务。通过该参数可以指定是否开启云安全、云监控等服务。若不指定该参数，则默认公共镜像开启云监控、云安全服务；自定义镜像与镜像市场镜像默认不开启云监控，云安全服务，而使用镜像里保留的服务。</p>
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// <p>用于保证请求幂等性的字符串。该字符串由客户生成，需保证不同请求之间唯一，最大值不超过64个ASCII字符。若不指定该参数，则无法保证请求的幂等性。</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>实例主机名。<br><li>点号（.）和短横线（-）不能作为 HostName 的首尾字符，不能连续使用。</li><br><li>Windows 实例：主机名名字符长度为[2, 15]，允许字母（不限制大小写）、数字和短横线（-）组成，不支持点号（.），不能全是数字。</li><br><li>其他类型（Linux 等）实例：主机名字符长度为[2, 60]，允许支持多个点号，点之间为一段，每段允许字母（不限制大小写）、数字和短横线（-）组成。</li><br><li>购买多台实例时：</p><ul><li>指定模式串  {R:x}：表示生成数字序列 [x, x+n-1]，其中 n为购买实例的数量。例如：输入 server_{R:3}，购买1台时，实例主机名为 server_3；购买2台时，实例主机名分别为 server_3、server_4。</li><li>指定模式串  {R:x,F:y}：y表示固定位数（可选），取值范围为 [0,8]，默认值 0表示不固定位数（等效于 {R:x}）。不足位时自动补零，例如：输入server_{R:3,F:3}，购买2台时，实例主机名为 server_003、server_004。若数字位数超过 y（如 {R:99,F:2}），以实际位数为准，例如：app_{R:99,F:2}，购买2台时，实例主机名为 app_99、app_100。</li><li>指定模式串 {IP}：自动替换为实例的内网IP地址。例如：输入 node-{IP}，实例主机名为 node-10.0.12.8；支持与序号模式串混合使用，例如：输入 web-{IP}-{R:1}，购买2台时，实例主机名分别为 web-10.0.12.8-1、web-10.0.12.9-2。</li><li>模式串需严格遵循 {R:x,F:y}、{R:x} 或 {IP} 格式，无效格式（如 {}）视为普通文本。支持多个模式串。</li><li>未指定模式串：实例主机名添加后缀 1、2...n，其中n表示购买实例的数量，例如 server_购买2台时生成 server_1、server_2。</li></li></ul>
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// <p>定时任务。通过该参数可以为实例指定定时任务，目前仅支持定时销毁。</p>
        /// </summary>
        [JsonProperty("ActionTimer")]
        public ActionTimer ActionTimer{ get; set; }

        /// <summary>
        /// <p>置放群组id，仅支持指定一个。</p>
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// <p>标签描述列表。通过指定该参数可以同时绑定标签到相应的云服务器、云硬盘实例。</p>
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }

        /// <summary>
        /// <p>实例的市场相关选项，如竞价实例相关参数，若指定实例的付费模式为竞价付费但没有传递该参数时，默认按当前固定折扣价格出价。</p>
        /// </summary>
        [JsonProperty("InstanceMarketOptions")]
        public InstanceMarketOptionsRequest InstanceMarketOptions{ get; set; }

        /// <summary>
        /// <p>提供给实例使用的用户数据，需要以 base64 方式编码，支持的最大数据大小为 16KB。关于获取此参数的详细介绍，请参阅<a href="https://cloud.tencent.com/document/product/213/17526">Windows</a>和<a href="https://cloud.tencent.com/document/product/213/17525">Linux</a>启动时运行命令。</p>
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// <p>自定义metadata，支持创建 CVM 时添加自定义元数据键值对。<br><strong>注：内测中</strong>。</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public Metadata Metadata{ get; set; }

        /// <summary>
        /// <p>是否只预检此次请求。<br>true：发送检查请求，不会创建实例。检查项包括是否填写了必需参数，请求格式，业务限制和云服务器库存。<br>如果检查不通过，则返回对应错误码；<br>如果检查通过，则返回RequestId.<br>false（默认）：发送正常请求，通过检查后直接创建实例</p>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>描述了实例CPU拓扑结构的相关信息。若不指定该参数，则按系统资源情况决定。</p>
        /// </summary>
        [JsonProperty("CpuTopology")]
        public CpuTopology CpuTopology{ get; set; }

        /// <summary>
        /// <p>CAM角色名称。可通过<a href="https://cloud.tencent.com/document/product/598/36223"> DescribeRoleList </a>接口返回值中的<code>RoleName</code>获取。</p>
        /// </summary>
        [JsonProperty("CamRoleName")]
        public string CamRoleName{ get; set; }

        /// <summary>
        /// <p>高性能计算集群ID。若创建的实例为高性能计算实例，需指定实例放置的集群，否则不可指定。</p>
        /// </summary>
        [JsonProperty("HpcClusterId")]
        public string HpcClusterId{ get; set; }

        /// <summary>
        /// <p>实例启动模板。</p>
        /// </summary>
        [JsonProperty("LaunchTemplate")]
        public LaunchTemplate LaunchTemplate{ get; set; }

        /// <summary>
        /// <p>指定专用集群创建。</p>
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// <p>指定CHC物理服务器来创建CHC云主机。</p>
        /// </summary>
        [JsonProperty("ChcIds")]
        public string[] ChcIds{ get; set; }

        /// <summary>
        /// <p>分区置放群组的分区序号，具体取决于所选置放群组的分区数量，如果选中的置放群组是分区置放群组，该值不传默认随机。(功能灰度中)</p>
        /// </summary>
        [JsonProperty("PartitionNumber")]
        public long? PartitionNumber{ get; set; }

        /// <summary>
        /// <p>实例销毁保护标志，表示是否允许通过api接口删除实例。取值范围：<br><li>true：表示开启实例保护，不允许通过api接口删除实例</li><br><li>false：表示关闭实例保护，允许通过api接口删除实例</li><br><br>默认取值：false。</p>
        /// </summary>
        [JsonProperty("DisableApiTermination")]
        public bool? DisableApiTermination{ get; set; }

        /// <summary>
        /// <p>实例是否开启巨型帧，取值范围：<br>&lt;li/&gt; true：表示实例开启巨型帧，只有支持巨型帧的机型可设置为true。<br>&lt;li/&gt;false：表示实例关闭巨型帧，只有支持巨型帧的机型可设置为false。<br> 支持巨型帧的实例规格： <a href="https://cloud.tencent.com/document/product/213/11518">实例规格</a></p>
        /// </summary>
        [JsonProperty("EnableJumboFrame")]
        public bool? EnableJumboFrame{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "VirtualPrivateCloud.", this.VirtualPrivateCloud);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "MinCount", this.MinCount);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamObj(map, prefix + "ActionTimer.", this.ActionTimer);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamObj(map, prefix + "InstanceMarketOptions.", this.InstanceMarketOptions);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamObj(map, prefix + "CpuTopology.", this.CpuTopology);
            this.SetParamSimple(map, prefix + "CamRoleName", this.CamRoleName);
            this.SetParamSimple(map, prefix + "HpcClusterId", this.HpcClusterId);
            this.SetParamObj(map, prefix + "LaunchTemplate.", this.LaunchTemplate);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamArraySimple(map, prefix + "ChcIds.", this.ChcIds);
            this.SetParamSimple(map, prefix + "PartitionNumber", this.PartitionNumber);
            this.SetParamSimple(map, prefix + "DisableApiTermination", this.DisableApiTermination);
            this.SetParamSimple(map, prefix + "EnableJumboFrame", this.EnableJumboFrame);
        }
    }
}

